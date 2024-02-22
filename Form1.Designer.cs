namespace CaseManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            search = new TabPage();
            tabPage2 = new TabPage();
            citationPage = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            nameLast = new TextBox();
            labelNameLast = new Label();
            labelNameFirst = new Label();
            nameFirst = new TextBox();
            labelNameMiddle = new Label();
            nameMiddle = new TextBox();
            labelPhysStreet = new Label();
            physStreet = new TextBox();
            labelPhysCity = new Label();
            physCity = new TextBox();
            labelPhysZip = new Label();
            dobPicker = new DateTimePicker();
            labelBirthday = new Label();
            physZip = new TextBox();
            comboBox1 = new ComboBox();
            labelPhysState = new Label();
            labelMailState = new Label();
            mailState = new ComboBox();
            mailZip = new TextBox();
            labelMailZip = new Label();
            labelMailCity = new Label();
            mailCity = new TextBox();
            labelMailStreet = new Label();
            mailStreet = new TextBox();
            heading = new Label();
            labelLicNumber = new Label();
            idNumber = new TextBox();
            labelLicState = new Label();
            licState = new ComboBox();
            labelAlias = new Label();
            alias = new TextBox();
            labelssn = new Label();
            ssn = new TextBox();
            labelLicType = new Label();
            licType = new ComboBox();
            labelHeight = new Label();
            height = new TextBox();
            labelWeight = new Label();
            weight = new TextBox();
            labelEyeColor = new Label();
            labelSex = new Label();
            eyeColor = new ComboBox();
            panel1 = new Panel();
            dotLabel = new Label();
            dotNumber = new TextBox();
            labelVehColor = new Label();
            vehColor = new TextBox();
            citNumber = new Label();
            labelCitNumber = new TextBox();
            labelViolationDate = new Label();
            violationDate = new DateTimePicker();
            labelPlateNumber = new Label();
            textBox1 = new TextBox();
            labelPlateState = new Label();
            comboBox2 = new ComboBox();
            labelVehType = new Label();
            labelVehMake = new Label();
            vehMake = new TextBox();
            labelVehModel = new Label();
            textBox4 = new TextBox();
            vehType = new ComboBox();
            labelVehYear = new Label();
            vehYear = new DateTimePicker();
            commercialVehicle = new CheckBox();
            hazmatPl = new CheckBox();
            pass16 = new CheckBox();
            labelTraffic = new Label();
            traffic = new ComboBox();
            labelWeather = new Label();
            weather = new ComboBox();
            labelRoad = new Label();
            road = new ComboBox();
            labelLight = new Label();
            light = new ComboBox();
            accident = new CheckBox();
            labelOfficer = new Label();
            officer = new ComboBox();
            labelLocation = new Label();
            location = new TextBox();
            labelOfficerID = new Label();
            officerID = new TextBox();
            labelDistrict = new Label();
            District = new TextBox();
            labelMilePost = new Label();
            milePost = new TextBox();
            labelOrd = new Label();
            ordinance = new ComboBox();
            sex = new ComboBox();
            labelCitedSpeed = new Label();
            citedSpeed = new TextBox();
            labelPostedSpeed = new Label();
            postedSpeed = new TextBox();
            ordSearch = new Button();
            tabControl1.SuspendLayout();
            citationPage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(search);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(citationPage);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(877, 650);
            tabControl1.TabIndex = 0;
            // 
            // search
            // 
            search.BorderStyle = BorderStyle.Fixed3D;
            search.Location = new Point(4, 24);
            search.Name = "search";
            search.Padding = new Padding(3);
            search.Size = new Size(869, 581);
            search.TabIndex = 0;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(869, 644);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // citationPage
            // 
            citationPage.Controls.Add(sex);
            citationPage.Controls.Add(panel1);
            citationPage.Controls.Add(eyeColor);
            citationPage.Controls.Add(labelSex);
            citationPage.Controls.Add(labelEyeColor);
            citationPage.Controls.Add(labelWeight);
            citationPage.Controls.Add(weight);
            citationPage.Controls.Add(labelHeight);
            citationPage.Controls.Add(height);
            citationPage.Controls.Add(labelLicType);
            citationPage.Controls.Add(licType);
            citationPage.Controls.Add(labelssn);
            citationPage.Controls.Add(ssn);
            citationPage.Controls.Add(labelAlias);
            citationPage.Controls.Add(alias);
            citationPage.Controls.Add(labelLicState);
            citationPage.Controls.Add(licState);
            citationPage.Controls.Add(labelLicNumber);
            citationPage.Controls.Add(idNumber);
            citationPage.Controls.Add(heading);
            citationPage.Controls.Add(labelMailState);
            citationPage.Controls.Add(mailState);
            citationPage.Controls.Add(mailZip);
            citationPage.Controls.Add(labelMailZip);
            citationPage.Controls.Add(labelMailCity);
            citationPage.Controls.Add(mailCity);
            citationPage.Controls.Add(labelMailStreet);
            citationPage.Controls.Add(mailStreet);
            citationPage.Controls.Add(labelPhysState);
            citationPage.Controls.Add(comboBox1);
            citationPage.Controls.Add(physZip);
            citationPage.Controls.Add(labelBirthday);
            citationPage.Controls.Add(dobPicker);
            citationPage.Controls.Add(labelPhysZip);
            citationPage.Controls.Add(labelPhysCity);
            citationPage.Controls.Add(physCity);
            citationPage.Controls.Add(labelPhysStreet);
            citationPage.Controls.Add(physStreet);
            citationPage.Controls.Add(labelNameMiddle);
            citationPage.Controls.Add(labelNameFirst);
            citationPage.Controls.Add(nameMiddle);
            citationPage.Controls.Add(nameFirst);
            citationPage.Controls.Add(labelNameLast);
            citationPage.Controls.Add(nameLast);
            citationPage.Location = new Point(4, 24);
            citationPage.Name = "citationPage";
            citationPage.Padding = new Padding(3);
            citationPage.Size = new Size(869, 622);
            citationPage.TabIndex = 2;
            citationPage.Text = "Citation Entry";
            citationPage.UseVisualStyleBackColor = true;
            // 
            // nameLast
            // 
            nameLast.Location = new Point(8, 43);
            nameLast.Name = "nameLast";
            nameLast.Size = new Size(250, 23);
            nameLast.TabIndex = 0;
            // 
            // labelNameLast
            // 
            labelNameLast.AutoSize = true;
            labelNameLast.Location = new Point(8, 69);
            labelNameLast.Name = "labelNameLast";
            labelNameLast.Size = new Size(63, 15);
            labelNameLast.TabIndex = 1;
            labelNameLast.Text = "Last Name";
            // 
            // labelNameFirst
            // 
            labelNameFirst.AutoSize = true;
            labelNameFirst.Location = new Point(264, 69);
            labelNameFirst.Name = "labelNameFirst";
            labelNameFirst.Size = new Size(64, 15);
            labelNameFirst.TabIndex = 3;
            labelNameFirst.Text = "First Name";
            labelNameFirst.Click += label2_Click;
            // 
            // nameFirst
            // 
            nameFirst.Location = new Point(264, 43);
            nameFirst.Name = "nameFirst";
            nameFirst.Size = new Size(248, 23);
            nameFirst.TabIndex = 2;
            // 
            // labelNameMiddle
            // 
            labelNameMiddle.AutoSize = true;
            labelNameMiddle.Location = new Point(518, 69);
            labelNameMiddle.Name = "labelNameMiddle";
            labelNameMiddle.Size = new Size(79, 15);
            labelNameMiddle.TabIndex = 3;
            labelNameMiddle.Text = "Middle Name";
            // 
            // nameMiddle
            // 
            nameMiddle.Location = new Point(518, 43);
            nameMiddle.Name = "nameMiddle";
            nameMiddle.Size = new Size(248, 23);
            nameMiddle.TabIndex = 2;
            // 
            // labelPhysStreet
            // 
            labelPhysStreet.AutoSize = true;
            labelPhysStreet.Location = new Point(10, 175);
            labelPhysStreet.Name = "labelPhysStreet";
            labelPhysStreet.Size = new Size(95, 15);
            labelPhysStreet.TabIndex = 5;
            labelPhysStreet.Text = "Physical Address";
            labelPhysStreet.Click += label4_Click;
            // 
            // physStreet
            // 
            physStreet.Location = new Point(10, 149);
            physStreet.Name = "physStreet";
            physStreet.Size = new Size(250, 23);
            physStreet.TabIndex = 4;
            // 
            // labelPhysCity
            // 
            labelPhysCity.AutoSize = true;
            labelPhysCity.Location = new Point(266, 175);
            labelPhysCity.Name = "labelPhysCity";
            labelPhysCity.Size = new Size(28, 15);
            labelPhysCity.TabIndex = 7;
            labelPhysCity.Text = "City";
            // 
            // physCity
            // 
            physCity.Location = new Point(266, 149);
            physCity.Name = "physCity";
            physCity.Size = new Size(160, 23);
            physCity.TabIndex = 6;
            // 
            // labelPhysZip
            // 
            labelPhysZip.AutoSize = true;
            labelPhysZip.Location = new Point(522, 175);
            labelPhysZip.Name = "labelPhysZip";
            labelPhysZip.Size = new Size(55, 15);
            labelPhysZip.TabIndex = 9;
            labelPhysZip.Text = "Zip Code";
            // 
            // dobPicker
            // 
            dobPicker.Format = DateTimePickerFormat.Short;
            dobPicker.Location = new Point(772, 43);
            dobPicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dobPicker.MinDate = new DateTime(1850, 1, 1, 0, 0, 0, 0);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(89, 23);
            dobPicker.TabIndex = 12;
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(772, 69);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(73, 15);
            labelBirthday.TabIndex = 13;
            labelBirthday.Text = "Date of Birth";
            labelBirthday.Click += label1_Click;
            // 
            // physZip
            // 
            physZip.Location = new Point(522, 149);
            physZip.Name = "physZip";
            physZip.Size = new Size(88, 23);
            physZip.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(432, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(84, 23);
            comboBox1.TabIndex = 16;
            // 
            // labelPhysState
            // 
            labelPhysState.AutoSize = true;
            labelPhysState.Location = new Point(432, 175);
            labelPhysState.Name = "labelPhysState";
            labelPhysState.Size = new Size(33, 15);
            labelPhysState.TabIndex = 17;
            labelPhysState.Text = "State";
            // 
            // labelMailState
            // 
            labelMailState.AutoSize = true;
            labelMailState.Location = new Point(432, 228);
            labelMailState.Name = "labelMailState";
            labelMailState.Size = new Size(33, 15);
            labelMailState.TabIndex = 25;
            labelMailState.Text = "State";
            // 
            // mailState
            // 
            mailState.FormattingEnabled = true;
            mailState.Location = new Point(432, 202);
            mailState.Name = "mailState";
            mailState.Size = new Size(84, 23);
            mailState.TabIndex = 24;
            // 
            // mailZip
            // 
            mailZip.Location = new Point(522, 202);
            mailZip.Name = "mailZip";
            mailZip.Size = new Size(88, 23);
            mailZip.TabIndex = 23;
            // 
            // labelMailZip
            // 
            labelMailZip.AutoSize = true;
            labelMailZip.Location = new Point(522, 228);
            labelMailZip.Name = "labelMailZip";
            labelMailZip.Size = new Size(55, 15);
            labelMailZip.TabIndex = 22;
            labelMailZip.Text = "Zip Code";
            // 
            // labelMailCity
            // 
            labelMailCity.AutoSize = true;
            labelMailCity.Location = new Point(266, 228);
            labelMailCity.Name = "labelMailCity";
            labelMailCity.Size = new Size(28, 15);
            labelMailCity.TabIndex = 21;
            labelMailCity.Text = "City";
            // 
            // mailCity
            // 
            mailCity.Location = new Point(266, 202);
            mailCity.Name = "mailCity";
            mailCity.Size = new Size(160, 23);
            mailCity.TabIndex = 20;
            // 
            // labelMailStreet
            // 
            labelMailStreet.AutoSize = true;
            labelMailStreet.Location = new Point(10, 228);
            labelMailStreet.Name = "labelMailStreet";
            labelMailStreet.Size = new Size(92, 15);
            labelMailStreet.TabIndex = 19;
            labelMailStreet.Text = "Mailing Address";
            // 
            // mailStreet
            // 
            mailStreet.Location = new Point(10, 202);
            mailStreet.Name = "mailStreet";
            mailStreet.Size = new Size(250, 23);
            mailStreet.TabIndex = 18;
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Location = new Point(8, 3);
            heading.Name = "heading";
            heading.Size = new Size(64, 15);
            heading.TabIndex = 26;
            heading.Text = "Party Entry";
            // 
            // labelLicNumber
            // 
            labelLicNumber.AutoSize = true;
            labelLicNumber.Location = new Point(8, 283);
            labelLicNumber.Name = "labelLicNumber";
            labelLicNumber.Size = new Size(109, 15);
            labelLicNumber.TabIndex = 28;
            labelLicNumber.Text = "License/ID Number";
            // 
            // idNumber
            // 
            idNumber.Location = new Point(8, 257);
            idNumber.Name = "idNumber";
            idNumber.Size = new Size(250, 23);
            idNumber.TabIndex = 27;
            // 
            // labelLicState
            // 
            labelLicState.AutoSize = true;
            labelLicState.Location = new Point(264, 283);
            labelLicState.Name = "labelLicState";
            labelLicState.Size = new Size(73, 15);
            labelLicState.TabIndex = 30;
            labelLicState.Text = "Issuing State";
            // 
            // licState
            // 
            licState.FormattingEnabled = true;
            licState.Location = new Point(264, 257);
            licState.Name = "licState";
            licState.Size = new Size(84, 23);
            licState.TabIndex = 29;
            // 
            // labelAlias
            // 
            labelAlias.AutoSize = true;
            labelAlias.Location = new Point(10, 122);
            labelAlias.Name = "labelAlias";
            labelAlias.Size = new Size(32, 15);
            labelAlias.TabIndex = 32;
            labelAlias.Text = "Alias";
            // 
            // alias
            // 
            alias.Location = new Point(10, 96);
            alias.Name = "alias";
            alias.Size = new Size(248, 23);
            alias.TabIndex = 31;
            // 
            // labelssn
            // 
            labelssn.AutoSize = true;
            labelssn.Location = new Point(266, 122);
            labelssn.Name = "labelssn";
            labelssn.Size = new Size(130, 15);
            labelssn.TabIndex = 34;
            labelssn.Text = "Social Security Number";
            // 
            // ssn
            // 
            ssn.Location = new Point(266, 96);
            ssn.Name = "ssn";
            ssn.Size = new Size(250, 23);
            ssn.TabIndex = 33;
            // 
            // labelLicType
            // 
            labelLicType.AutoSize = true;
            labelLicType.Location = new Point(354, 283);
            labelLicType.Name = "labelLicType";
            labelLicType.Size = new Size(73, 15);
            labelLicType.TabIndex = 36;
            labelLicType.Text = "License Type";
            // 
            // licType
            // 
            licType.FormattingEnabled = true;
            licType.Location = new Point(354, 257);
            licType.Name = "licType";
            licType.Size = new Size(70, 23);
            licType.TabIndex = 35;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(701, 122);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(43, 15);
            labelHeight.TabIndex = 40;
            labelHeight.Text = "Height";
            // 
            // height
            // 
            height.Location = new Point(701, 96);
            height.Name = "height";
            height.Size = new Size(160, 23);
            height.TabIndex = 39;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(703, 175);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(45, 15);
            labelWeight.TabIndex = 42;
            labelWeight.Text = "Weight";
            // 
            // weight
            // 
            weight.Location = new Point(703, 149);
            weight.Name = "weight";
            weight.Size = new Size(160, 23);
            weight.TabIndex = 41;
            // 
            // labelEyeColor
            // 
            labelEyeColor.AutoSize = true;
            labelEyeColor.Location = new Point(703, 230);
            labelEyeColor.Name = "labelEyeColor";
            labelEyeColor.Size = new Size(57, 15);
            labelEyeColor.TabIndex = 44;
            labelEyeColor.Text = "Eye Color";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(522, 122);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(25, 15);
            labelSex.TabIndex = 46;
            labelSex.Text = "Sex";
            // 
            // eyeColor
            // 
            eyeColor.FormattingEnabled = true;
            eyeColor.Location = new Point(703, 204);
            eyeColor.Name = "eyeColor";
            eyeColor.Size = new Size(84, 23);
            eyeColor.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.Controls.Add(ordSearch);
            panel1.Controls.Add(labelPostedSpeed);
            panel1.Controls.Add(postedSpeed);
            panel1.Controls.Add(labelCitedSpeed);
            panel1.Controls.Add(citedSpeed);
            panel1.Controls.Add(labelOrd);
            panel1.Controls.Add(ordinance);
            panel1.Controls.Add(labelMilePost);
            panel1.Controls.Add(milePost);
            panel1.Controls.Add(labelDistrict);
            panel1.Controls.Add(District);
            panel1.Controls.Add(labelOfficerID);
            panel1.Controls.Add(officerID);
            panel1.Controls.Add(labelLocation);
            panel1.Controls.Add(location);
            panel1.Controls.Add(labelOfficer);
            panel1.Controls.Add(officer);
            panel1.Controls.Add(accident);
            panel1.Controls.Add(labelLight);
            panel1.Controls.Add(light);
            panel1.Controls.Add(labelRoad);
            panel1.Controls.Add(road);
            panel1.Controls.Add(labelWeather);
            panel1.Controls.Add(weather);
            panel1.Controls.Add(labelTraffic);
            panel1.Controls.Add(pass16);
            panel1.Controls.Add(traffic);
            panel1.Controls.Add(hazmatPl);
            panel1.Controls.Add(commercialVehicle);
            panel1.Controls.Add(labelVehYear);
            panel1.Controls.Add(vehYear);
            panel1.Controls.Add(vehType);
            panel1.Controls.Add(labelVehModel);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(labelVehMake);
            panel1.Controls.Add(vehMake);
            panel1.Controls.Add(labelVehType);
            panel1.Controls.Add(labelPlateState);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(labelPlateNumber);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelViolationDate);
            panel1.Controls.Add(violationDate);
            panel1.Controls.Add(citNumber);
            panel1.Controls.Add(labelCitNumber);
            panel1.Controls.Add(dotLabel);
            panel1.Controls.Add(dotNumber);
            panel1.Controls.Add(labelVehColor);
            panel1.Controls.Add(vehColor);
            panel1.Location = new Point(8, 312);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 314);
            panel1.TabIndex = 48;
            // 
            // dotLabel
            // 
            dotLabel.AutoSize = true;
            dotLabel.Location = new Point(12, 145);
            dotLabel.Name = "dotLabel";
            dotLabel.Size = new Size(76, 15);
            dotLabel.TabIndex = 44;
            dotLabel.Text = "DOT Number";
            // 
            // dotNumber
            // 
            dotNumber.Location = new Point(12, 119);
            dotNumber.Name = "dotNumber";
            dotNumber.Size = new Size(250, 23);
            dotNumber.TabIndex = 43;
            // 
            // labelVehColor
            // 
            labelVehColor.AutoSize = true;
            labelVehColor.Location = new Point(677, 41);
            labelVehColor.Name = "labelVehColor";
            labelVehColor.Size = new Size(76, 15);
            labelVehColor.TabIndex = 42;
            labelVehColor.Text = "Vehicle Color";
            labelVehColor.Click += label1_Click_1;
            // 
            // vehColor
            // 
            vehColor.Location = new Point(677, 13);
            vehColor.Name = "vehColor";
            vehColor.Size = new Size(81, 23);
            vehColor.TabIndex = 39;
            // 
            // citNumber
            // 
            citNumber.AutoSize = true;
            citNumber.Location = new Point(12, 39);
            citNumber.Name = "citNumber";
            citNumber.Size = new Size(96, 15);
            citNumber.TabIndex = 46;
            citNumber.Text = "Citation Number";
            // 
            // labelCitNumber
            // 
            labelCitNumber.Location = new Point(12, 13);
            labelCitNumber.Name = "labelCitNumber";
            labelCitNumber.Size = new Size(250, 23);
            labelCitNumber.TabIndex = 45;
            // 
            // labelViolationDate
            // 
            labelViolationDate.AutoSize = true;
            labelViolationDate.Location = new Point(269, 39);
            labelViolationDate.Name = "labelViolationDate";
            labelViolationDate.Size = new Size(81, 15);
            labelViolationDate.TabIndex = 48;
            labelViolationDate.Text = "Violation Date";
            // 
            // violationDate
            // 
            violationDate.CustomFormat = "MM/dd/yyyy hh:mm";
            violationDate.Format = DateTimePickerFormat.Custom;
            violationDate.Location = new Point(269, 13);
            violationDate.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            violationDate.MinDate = new DateTime(1850, 1, 1, 0, 0, 0, 0);
            violationDate.Name = "violationDate";
            violationDate.Size = new Size(131, 23);
            violationDate.TabIndex = 47;
            // 
            // labelPlateNumber
            // 
            labelPlateNumber.AutoSize = true;
            labelPlateNumber.Location = new Point(12, 92);
            labelPlateNumber.Name = "labelPlateNumber";
            labelPlateNumber.Size = new Size(122, 15);
            labelPlateNumber.TabIndex = 50;
            labelPlateNumber.Text = "License Plate Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 49;
            // 
            // labelPlateState
            // 
            labelPlateState.AutoSize = true;
            labelPlateState.Location = new Point(268, 92);
            labelPlateState.Name = "labelPlateState";
            labelPlateState.Size = new Size(73, 15);
            labelPlateState.TabIndex = 52;
            labelPlateState.Text = "Issuing State";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(268, 66);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(84, 23);
            comboBox2.TabIndex = 51;
            // 
            // labelVehType
            // 
            labelVehType.AutoSize = true;
            labelVehType.Location = new Point(587, 41);
            labelVehType.Name = "labelVehType";
            labelVehType.Size = new Size(71, 15);
            labelVehType.TabIndex = 54;
            labelVehType.Text = "Vehicle Type";
            // 
            // labelVehMake
            // 
            labelVehMake.AutoSize = true;
            labelVehMake.Location = new Point(677, 92);
            labelVehMake.Name = "labelVehMake";
            labelVehMake.Size = new Size(76, 15);
            labelVehMake.TabIndex = 56;
            labelVehMake.Text = "Vehicle Make";
            // 
            // vehMake
            // 
            vehMake.Location = new Point(677, 66);
            vehMake.Name = "vehMake";
            vehMake.Size = new Size(160, 23);
            vehMake.TabIndex = 55;
            // 
            // labelVehModel
            // 
            labelVehModel.AutoSize = true;
            labelVehModel.Location = new Point(677, 145);
            labelVehModel.Name = "labelVehModel";
            labelVehModel.Size = new Size(81, 15);
            labelVehModel.TabIndex = 58;
            labelVehModel.Text = "Vehicle Model";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(677, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 23);
            textBox4.TabIndex = 57;
            // 
            // vehType
            // 
            vehType.FormattingEnabled = true;
            vehType.Location = new Point(587, 15);
            vehType.Name = "vehType";
            vehType.Size = new Size(84, 23);
            vehType.TabIndex = 59;
            // 
            // labelVehYear
            // 
            labelVehYear.AutoSize = true;
            labelVehYear.Location = new Point(764, 39);
            labelVehYear.Name = "labelVehYear";
            labelVehYear.Size = new Size(69, 15);
            labelVehYear.TabIndex = 61;
            labelVehYear.Text = "Vehicle Year";
            // 
            // vehYear
            // 
            vehYear.CustomFormat = "yyyy";
            vehYear.Format = DateTimePickerFormat.Custom;
            vehYear.Location = new Point(764, 13);
            vehYear.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            vehYear.MinDate = new DateTime(1850, 1, 1, 0, 0, 0, 0);
            vehYear.Name = "vehYear";
            vehYear.Size = new Size(86, 23);
            vehYear.TabIndex = 60;
            // 
            // commercialVehicle
            // 
            commercialVehicle.AutoSize = true;
            commercialVehicle.Location = new Point(12, 236);
            commercialVehicle.Name = "commercialVehicle";
            commercialVehicle.Size = new Size(131, 19);
            commercialVehicle.TabIndex = 62;
            commercialVehicle.Text = "Commercial Vehicle";
            commercialVehicle.UseVisualStyleBackColor = true;
            // 
            // hazmatPl
            // 
            hazmatPl.AutoSize = true;
            hazmatPl.Location = new Point(149, 236);
            hazmatPl.Name = "hazmatPl";
            hazmatPl.Size = new Size(83, 19);
            hazmatPl.TabIndex = 63;
            hazmatPl.Text = "Hazmat PL";
            hazmatPl.UseVisualStyleBackColor = true;
            // 
            // pass16
            // 
            pass16.AutoSize = true;
            pass16.Location = new Point(238, 236);
            pass16.Name = "pass16";
            pass16.Size = new Size(102, 19);
            pass16.TabIndex = 64;
            pass16.Text = "Passenger 16+";
            pass16.UseVisualStyleBackColor = true;
            // 
            // labelTraffic
            // 
            labelTraffic.AutoSize = true;
            labelTraffic.Location = new Point(12, 202);
            labelTraffic.Name = "labelTraffic";
            labelTraffic.Size = new Size(39, 15);
            labelTraffic.TabIndex = 50;
            labelTraffic.Text = "Traffic";
            // 
            // traffic
            // 
            traffic.FormattingEnabled = true;
            traffic.Location = new Point(12, 176);
            traffic.Name = "traffic";
            traffic.Size = new Size(53, 23);
            traffic.TabIndex = 49;
            // 
            // labelWeather
            // 
            labelWeather.AutoSize = true;
            labelWeather.ImageAlign = ContentAlignment.MiddleLeft;
            labelWeather.Location = new Point(71, 202);
            labelWeather.Name = "labelWeather";
            labelWeather.Size = new Size(51, 15);
            labelWeather.TabIndex = 66;
            labelWeather.Text = "Weather";
            // 
            // weather
            // 
            weather.FormattingEnabled = true;
            weather.Location = new Point(71, 176);
            weather.Name = "weather";
            weather.Size = new Size(51, 23);
            weather.TabIndex = 65;
            // 
            // labelRoad
            // 
            labelRoad.AutoSize = true;
            labelRoad.Location = new Point(128, 202);
            labelRoad.Name = "labelRoad";
            labelRoad.Size = new Size(34, 15);
            labelRoad.TabIndex = 68;
            labelRoad.Text = "Road";
            // 
            // road
            // 
            road.FormattingEnabled = true;
            road.Location = new Point(128, 176);
            road.Name = "road";
            road.Size = new Size(52, 23);
            road.TabIndex = 67;
            // 
            // labelLight
            // 
            labelLight.AutoSize = true;
            labelLight.Location = new Point(186, 202);
            labelLight.Name = "labelLight";
            labelLight.Size = new Size(34, 15);
            labelLight.TabIndex = 70;
            labelLight.Text = "Light";
            // 
            // light
            // 
            light.FormattingEnabled = true;
            light.Location = new Point(186, 176);
            light.Name = "light";
            light.Size = new Size(47, 23);
            light.TabIndex = 69;
            // 
            // accident
            // 
            accident.AutoSize = true;
            accident.Location = new Point(239, 178);
            accident.Name = "accident";
            accident.Size = new Size(73, 19);
            accident.TabIndex = 71;
            accident.Text = "Accident";
            accident.UseVisualStyleBackColor = true;
            // 
            // labelOfficer
            // 
            labelOfficer.AutoSize = true;
            labelOfficer.Location = new Point(600, 287);
            labelOfficer.Name = "labelOfficer";
            labelOfficer.Size = new Size(43, 15);
            labelOfficer.TabIndex = 73;
            labelOfficer.Text = "Officer";
            // 
            // officer
            // 
            officer.FormattingEnabled = true;
            officer.Location = new Point(600, 261);
            officer.Name = "officer";
            officer.Size = new Size(237, 23);
            officer.TabIndex = 72;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(12, 287);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(53, 15);
            labelLocation.TabIndex = 76;
            labelLocation.Text = "Location";
            // 
            // location
            // 
            location.Location = new Point(12, 261);
            location.Name = "location";
            location.Size = new Size(250, 23);
            location.TabIndex = 75;
            // 
            // labelOfficerID
            // 
            labelOfficerID.AutoSize = true;
            labelOfficerID.Location = new Point(268, 287);
            labelOfficerID.Name = "labelOfficerID";
            labelOfficerID.Size = new Size(77, 15);
            labelOfficerID.TabIndex = 78;
            labelOfficerID.Text = "Identification";
            // 
            // officerID
            // 
            officerID.Location = new Point(268, 261);
            officerID.Name = "officerID";
            officerID.Size = new Size(84, 23);
            officerID.TabIndex = 77;
            // 
            // labelDistrict
            // 
            labelDistrict.AutoSize = true;
            labelDistrict.Location = new Point(358, 287);
            labelDistrict.Name = "labelDistrict";
            labelDistrict.Size = new Size(44, 15);
            labelDistrict.TabIndex = 80;
            labelDistrict.Text = "District";
            // 
            // District
            // 
            District.Location = new Point(358, 261);
            District.Name = "District";
            District.Size = new Size(84, 23);
            District.TabIndex = 79;
            // 
            // labelMilePost
            // 
            labelMilePost.AutoSize = true;
            labelMilePost.Location = new Point(448, 287);
            labelMilePost.Name = "labelMilePost";
            labelMilePost.Size = new Size(56, 15);
            labelMilePost.TabIndex = 82;
            labelMilePost.Text = "Mile Post";
            // 
            // milePost
            // 
            milePost.Location = new Point(448, 261);
            milePost.Name = "milePost";
            milePost.Size = new Size(84, 23);
            milePost.TabIndex = 81;
            // 
            // labelOrd
            // 
            labelOrd.AutoSize = true;
            labelOrd.Location = new Point(358, 145);
            labelOrd.Name = "labelOrd";
            labelOrd.Size = new Size(62, 15);
            labelOrd.TabIndex = 84;
            labelOrd.Text = "Ordinance";
            // 
            // ordinance
            // 
            ordinance.AutoCompleteMode = AutoCompleteMode.Suggest;
            ordinance.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ordinance.FormattingEnabled = true;
            ordinance.Location = new Point(358, 119);
            ordinance.MaxDropDownItems = 100;
            ordinance.MaxLength = 80;
            ordinance.Name = "ordinance";
            ordinance.Size = new Size(237, 23);
            ordinance.Sorted = true;
            ordinance.TabIndex = 83;
            // 
            // sex
            // 
            sex.FormattingEnabled = true;
            sex.Location = new Point(522, 96);
            sex.Name = "sex";
            sex.Size = new Size(84, 23);
            sex.TabIndex = 49;
            // 
            // labelCitedSpeed
            // 
            labelCitedSpeed.AutoSize = true;
            labelCitedSpeed.Location = new Point(358, 202);
            labelCitedSpeed.Name = "labelCitedSpeed";
            labelCitedSpeed.Size = new Size(70, 15);
            labelCitedSpeed.TabIndex = 86;
            labelCitedSpeed.Text = "Cited Speed";
            // 
            // citedSpeed
            // 
            citedSpeed.Location = new Point(358, 176);
            citedSpeed.Name = "citedSpeed";
            citedSpeed.Size = new Size(86, 23);
            citedSpeed.TabIndex = 85;
            // 
            // labelPostedSpeed
            // 
            labelPostedSpeed.AutoSize = true;
            labelPostedSpeed.Location = new Point(462, 202);
            labelPostedSpeed.Name = "labelPostedSpeed";
            labelPostedSpeed.Size = new Size(78, 15);
            labelPostedSpeed.TabIndex = 88;
            labelPostedSpeed.Text = "Posted Speed";
            // 
            // postedSpeed
            // 
            postedSpeed.Location = new Point(462, 176);
            postedSpeed.Name = "postedSpeed";
            postedSpeed.Size = new Size(86, 23);
            postedSpeed.TabIndex = 87;
            // 
            // ordSearch
            // 
            ordSearch.Location = new Point(602, 119);
            ordSearch.Name = "ordSearch";
            ordSearch.Size = new Size(56, 23);
            ordSearch.TabIndex = 89;
            ordSearch.Text = "Search";
            ordSearch.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(877, 702);
            Controls.Add(tabControl1);
            Name = "Main";
            Text = "Main";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            citationPage.ResumeLayout(false);
            citationPage.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage search;
        private TabPage tabPage2;
        private TabPage citationPage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label labelNameLast;
        private TextBox nameLast;
        private Label labelNameFirst;
        private TextBox nameFirst;
        private Label labelPhysStreet;
        private TextBox physStreet;
        private Label labelNameMiddle;
        private TextBox nameMiddle;
        private Label labelPhysZip;
        private Label labelPhysCity;
        private TextBox physCity;
        private Label labelBirthday;
        private DateTimePicker dobPicker;
        private Label labelPhysState;
        private ComboBox comboBox1;
        private TextBox physZip;
        private Label labelLicState;
        private ComboBox licState;
        private Label labelLicNumber;
        private TextBox idNumber;
        private Label heading;
        private Label labelMailState;
        private ComboBox mailState;
        private TextBox mailZip;
        private Label labelMailZip;
        private Label labelMailCity;
        private TextBox mailCity;
        private Label labelMailStreet;
        private TextBox mailStreet;
        private Label labelssn;
        private TextBox ssn;
        private Label labelAlias;
        private TextBox alias;
        private Label labelLicType;
        private ComboBox licType;
        private Label labelSex;
        private Label labelEyeColor;
        private Label labelWeight;
        private TextBox weight;
        private Label labelHeight;
        private TextBox height;
        private Panel panel1;
        private ComboBox eyeColor;
        private Label labelViolationDate;
        private DateTimePicker violationDate;
        private Label citNumber;
        private TextBox labelCitNumber;
        private Label dotLabel;
        private TextBox dotNumber;
        private Label labelVehColor;
        private TextBox vehColor;
        private Label labelPlateNumber;
        private TextBox textBox1;
        private Label labelPlateState;
        private ComboBox comboBox2;
        private ComboBox vehType;
        private Label labelVehModel;
        private TextBox textBox4;
        private Label labelVehMake;
        private TextBox vehMake;
        private Label labelVehType;
        private Label labelVehYear;
        private DateTimePicker vehYear;
        private CheckBox commercialVehicle;
        private Label labelLight;
        private ComboBox light;
        private Label labelRoad;
        private ComboBox road;
        private Label labelWeather;
        private ComboBox weather;
        private Label labelTraffic;
        private CheckBox pass16;
        private ComboBox traffic;
        private CheckBox hazmatPl;
        private CheckBox accident;
        private Label labelOfficer;
        private ComboBox officer;
        private Label labelMilePost;
        private TextBox milePost;
        private Label labelDistrict;
        private TextBox District;
        private Label labelOfficerID;
        private TextBox officerID;
        private Label labelLocation;
        private TextBox location;
        private Label labelOrd;
        private ComboBox ordinance;
        private ComboBox sex;
        private Label labelPostedSpeed;
        private TextBox postedSpeed;
        private Label labelCitedSpeed;
        private TextBox citedSpeed;
        private Button ordSearch;
    }
}