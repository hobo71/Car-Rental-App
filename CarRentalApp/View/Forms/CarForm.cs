﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.Forms
{
    public partial class CarForm : Form
    {
        private Car _car;
        private FormMode _mode;
        private readonly Action<Car> _onCloseCallBack;
        private readonly UnitOfWork _unitOfWork;
        private bool _refreshParent;
        private readonly Point _firstControlLocation = new Point(40, 541);

        public CarForm(FormMode mode, Action<Car> onCloseCallBack = null, Car car = null)
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _mode = mode;
            _onCloseCallBack = onCloseCallBack;
            _car = car ?? new Car();
        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidateInputs()
        {
            if (carNameTextBox.Text.Trim().Length < 3)
            {
                OnValidating("* Name not Valid at least 3 chars");
                return false;
            }

            if (string.IsNullOrWhiteSpace(carClassificationComboBox.Text))
            {
                OnValidating("* Classification is required");
                return false;
            }

            if (carPricePerDayNumericUpDown.Value == 0)
            {
                OnValidating("* Price not valid greater than 0");
                return false;
            }


            if (carDescriptionTextBox.Text.Trim().Length < 6)
            {
                OnValidating("* Description may be a least 6 chars");
                return false;
            }

            if (carNextDrainDateTimePicker.Value < carPurchaseDateTimePicker.Value)
            {
                OnValidating("*Next Drain Date Can't be before purchase date");
                return false;
            }


            return true;
        }

        private bool ValidateInputsToCar()
        {
            if (!ValidateInputs()) return false;

            _car.Name = carNameTextBox.Text;
            _car.SetPicture(carPictureBox.Image);
            _car.LicensePlate = carLicensePlateTextBox.Text;
            _car.Classification =
                _unitOfWork.Classifications.SingleOrDefault(c => c.Name == carClassificationComboBox.Text);
            _car.PricePerDay = carPricePerDayNumericUpDown.Value;
            _car.PurchaseDate = carPurchaseDateTimePicker.Value;
            _car.NextDrainDate = carNextDrainDateTimePicker.Value;
            _car.Description = carDescriptionTextBox.Text;

            return true;
        }

        private void OnChildFromClosed(bool refresh = false)
        {
            if (refresh)
                RefreshClassificationsDropDown();
        }

        private void UpdateCarInfoUi()
        {
            carNameTextBox.Text = _car.Name ?? string.Empty;
            carLicensePlateTextBox.Text = _car.LicensePlate ?? string.Empty;
            carPricePerDayNumericUpDown.Value = _car.PricePerDay;
            carClassificationComboBox.SelectedItem = _car.Classification != null ? _car.Classification.Name : string.Empty;
            carDescriptionTextBox.Text = _car.Description ?? string.Empty;
            carPictureBox.Image = _car.GetPicture();
            if (_car.NextDrainDate != null) carNextDrainDateTimePicker.Value = (DateTime) _car.NextDrainDate;
            if (_car.PurchaseDate != null) carPurchaseDateTimePicker.Value = (DateTime) _car.PurchaseDate;
        }

        private void RefreshClassificationsDropDown()
        {
            var classifications = _unitOfWork.Classifications.GetAll().ToList();
            var classificationNames = new List<string>();
            classifications.ForEach(c => classificationNames.Add(c.Name));
            carClassificationComboBox.DataSource = classificationNames.ToArray();
            if (carClassificationComboBox.Items.Count != 0)
                carClassificationComboBox.SelectedItem = _car.Classification != null
                    ? _car.Classification.Name
                    : classificationNames.First();
        }

        private void AddNewClassificationButton_Click(object sender, EventArgs e)
        {
            var classificationForm = new ClassificationForm(OnChildFromClosed);
            classificationForm.Show();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            RefreshClassificationsDropDown();
            UpdateControlsUi();
            if (_mode != FormMode.AddNew)
                UpdateCarInfoUi();
        }

        private void UpdateControlsUi(bool saveCompleted = false)
        {
            var state = _mode != FormMode.View;
            carNameTextBox.Enabled = state;
            carClassificationComboBox.Enabled = state;
            carChoosePicturButton.Enabled = state;
            carDescriptionTextBox.Enabled = state;
            carLicensePlateTextBox.Enabled = state;
            carNextDrainDateTimePicker.Enabled = state;
            carPricePerDayNumericUpDown.Enabled = state;
            carPurchaseDateTimePicker.Enabled = state;
            AddNewClassificationButton.Enabled = state;
            carChoosePicturButton.Enabled = state;
            saveButton.Visible = state;
            addMoreButton.Visible = !state;

            if (_mode == FormMode.View && saveCompleted)
            {
                addMoreButton.Location = _firstControlLocation;
            }
            else
            {
                saveButton.Location = _firstControlLocation;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsToCar()) return;

            switch (_mode)
            {
                case FormMode.AddNew:
                {
                    try
                    {
                        _unitOfWork.Cars.Add(_car);
                        _unitOfWork.Complete();
                        _refreshParent = true;
                        _mode = FormMode.View;
                        UpdateControlsUi(true);
                        OnValidating("Successfully saved !", false);

                     }
                        catch (FormattedDbEntityValidationException exception)
                    {
                        OnValidating(exception.Message);
                    }
                    break;

                }
                case FormMode.Edit:
                {
                    try
                    {
                        _unitOfWork.Complete();
                        _mode = FormMode.View;
                        _refreshParent = true;
                        UpdateControlsUi(true);
                        OnValidating("Successfully updated !", false);

                    }
                        catch (FormattedDbEntityValidationException exception)
                    {
                        OnValidating(exception.Message);
                    }
                    break;
                }
                case FormMode.View:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void CarChoosePictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog
                {
                    Filter = @"Image Files(*.jpg; *.jpeg; *png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp"
                };


                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                var img = Image.FromFile(openFileDialog.FileName);
                carPictureBox.Image = img;
                carPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                OnValidating("Picture not valid");

            }
        }

        private void CarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _onCloseCallBack(_refreshParent ? _car : null);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddMoreButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.AddNew;
            _car = new Car()
            {
                NextDrainDate = DateTime.Today,
                PurchaseDate = DateTime.Today,
            };
            UpdateCarInfoUi();
            UpdateControlsUi();

        }
    }
}