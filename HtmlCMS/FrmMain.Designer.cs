namespace HtmlCMS
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.lstSite = new System.Windows.Forms.ListBox();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddSite, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstSite, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.grdList, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 615);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnAddSite
            // 
            this.btnAddSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSite.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddSite.Image = global::HtmlCMS.Properties.Resources._1361237535_add;
            this.btnAddSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSite.Location = new System.Drawing.Point(546, 34);
            this.btnAddSite.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(308, 53);
            this.btnAddSite.TabIndex = 9;
            this.btnAddSite.Text = "Add New Site";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // lstSite
            // 
            this.lstSite.AccessibleDescription = "";
            this.lstSite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSite.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSite.FormattingEnabled = true;
            this.lstSite.ItemHeight = 16;
            this.lstSite.Location = new System.Drawing.Point(546, 125);
            this.lstSite.Margin = new System.Windows.Forms.Padding(4);
            this.lstSite.Name = "lstSite";
            this.lstSite.Size = new System.Drawing.Size(308, 453);
            this.lstSite.TabIndex = 10;
            this.lstSite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSite_MouseClick);
            this.lstSite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSite_MouseDoubleClick);
            // 
            // grdList
            // 
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList.Location = new System.Drawing.Point(48, 124);
            this.grdList.Name = "grdList";
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(446, 455);
            this.grdList.TabIndex = 11;
            this.grdList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdList_KeyUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnConvert, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpload, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSettings, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(48, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(446, 55);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnConvert
            // 
            this.btnConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConvert.Location = new System.Drawing.Point(3, 3);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(142, 49);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Generate";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpload.Image = global::HtmlCMS.Properties.Resources._1361237613_upload_arrow_up;
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(151, 3);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(142, 49);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Location = new System.Drawing.Point(299, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(144, 49);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "_abkhazia.png");
            this.ImgList.Images.SetKeyName(1, "_british-antarctic-territory.png");
            this.ImgList.Images.SetKeyName(2, "_commonwealth.png");
            this.ImgList.Images.SetKeyName(3, "_england.png");
            this.ImgList.Images.SetKeyName(4, "_gosquared.png");
            this.ImgList.Images.SetKeyName(5, "_mars.png");
            this.ImgList.Images.SetKeyName(6, "_nagorno-karabakh.png");
            this.ImgList.Images.SetKeyName(7, "_nato.png");
            this.ImgList.Images.SetKeyName(8, "_northern-cyprus.png");
            this.ImgList.Images.SetKeyName(9, "_olympics.png");
            this.ImgList.Images.SetKeyName(10, "_red-cross.png");
            this.ImgList.Images.SetKeyName(11, "_scotland.png");
            this.ImgList.Images.SetKeyName(12, "_somaliland.png");
            this.ImgList.Images.SetKeyName(13, "_south-ossetia.png");
            this.ImgList.Images.SetKeyName(14, "_united-nations.png");
            this.ImgList.Images.SetKeyName(15, "_wales.png");
            this.ImgList.Images.SetKeyName(16, "AD.png");
            this.ImgList.Images.SetKeyName(17, "AE.png");
            this.ImgList.Images.SetKeyName(18, "AF.png");
            this.ImgList.Images.SetKeyName(19, "AG.png");
            this.ImgList.Images.SetKeyName(20, "AI.png");
            this.ImgList.Images.SetKeyName(21, "AL.png");
            this.ImgList.Images.SetKeyName(22, "AM.png");
            this.ImgList.Images.SetKeyName(23, "AN.png");
            this.ImgList.Images.SetKeyName(24, "AO.png");
            this.ImgList.Images.SetKeyName(25, "AQ.png");
            this.ImgList.Images.SetKeyName(26, "AR.png");
            this.ImgList.Images.SetKeyName(27, "AS.png");
            this.ImgList.Images.SetKeyName(28, "AT.png");
            this.ImgList.Images.SetKeyName(29, "AU.png");
            this.ImgList.Images.SetKeyName(30, "AW.png");
            this.ImgList.Images.SetKeyName(31, "AX.png");
            this.ImgList.Images.SetKeyName(32, "AZ.png");
            this.ImgList.Images.SetKeyName(33, "BA.png");
            this.ImgList.Images.SetKeyName(34, "BB.png");
            this.ImgList.Images.SetKeyName(35, "BD.png");
            this.ImgList.Images.SetKeyName(36, "BE.png");
            this.ImgList.Images.SetKeyName(37, "BF.png");
            this.ImgList.Images.SetKeyName(38, "BG.png");
            this.ImgList.Images.SetKeyName(39, "BH.png");
            this.ImgList.Images.SetKeyName(40, "BI.png");
            this.ImgList.Images.SetKeyName(41, "BJ.png");
            this.ImgList.Images.SetKeyName(42, "BL.png");
            this.ImgList.Images.SetKeyName(43, "BM.png");
            this.ImgList.Images.SetKeyName(44, "BN.png");
            this.ImgList.Images.SetKeyName(45, "BO.png");
            this.ImgList.Images.SetKeyName(46, "BR.png");
            this.ImgList.Images.SetKeyName(47, "BS.png");
            this.ImgList.Images.SetKeyName(48, "BT.png");
            this.ImgList.Images.SetKeyName(49, "BW.png");
            this.ImgList.Images.SetKeyName(50, "BY.png");
            this.ImgList.Images.SetKeyName(51, "BZ.png");
            this.ImgList.Images.SetKeyName(52, "CA.png");
            this.ImgList.Images.SetKeyName(53, "CC.png");
            this.ImgList.Images.SetKeyName(54, "CD.png");
            this.ImgList.Images.SetKeyName(55, "CF.png");
            this.ImgList.Images.SetKeyName(56, "CG.png");
            this.ImgList.Images.SetKeyName(57, "CH.png");
            this.ImgList.Images.SetKeyName(58, "CI.png");
            this.ImgList.Images.SetKeyName(59, "CK.png");
            this.ImgList.Images.SetKeyName(60, "CL.png");
            this.ImgList.Images.SetKeyName(61, "CM.png");
            this.ImgList.Images.SetKeyName(62, "CN.png");
            this.ImgList.Images.SetKeyName(63, "CO.png");
            this.ImgList.Images.SetKeyName(64, "CR.png");
            this.ImgList.Images.SetKeyName(65, "CU.png");
            this.ImgList.Images.SetKeyName(66, "CV.png");
            this.ImgList.Images.SetKeyName(67, "CX.png");
            this.ImgList.Images.SetKeyName(68, "CY.png");
            this.ImgList.Images.SetKeyName(69, "CZ.png");
            this.ImgList.Images.SetKeyName(70, "DE.png");
            this.ImgList.Images.SetKeyName(71, "DJ.png");
            this.ImgList.Images.SetKeyName(72, "DK.png");
            this.ImgList.Images.SetKeyName(73, "DM.png");
            this.ImgList.Images.SetKeyName(74, "DO.png");
            this.ImgList.Images.SetKeyName(75, "DZ.png");
            this.ImgList.Images.SetKeyName(76, "EC.png");
            this.ImgList.Images.SetKeyName(77, "EE.png");
            this.ImgList.Images.SetKeyName(78, "EG.png");
            this.ImgList.Images.SetKeyName(79, "EH.png");
            this.ImgList.Images.SetKeyName(80, "ER.png");
            this.ImgList.Images.SetKeyName(81, "ES.png");
            this.ImgList.Images.SetKeyName(82, "ET.png");
            this.ImgList.Images.SetKeyName(83, "EU.png");
            this.ImgList.Images.SetKeyName(84, "FI.png");
            this.ImgList.Images.SetKeyName(85, "FJ.png");
            this.ImgList.Images.SetKeyName(86, "FK.png");
            this.ImgList.Images.SetKeyName(87, "FM.png");
            this.ImgList.Images.SetKeyName(88, "FO.png");
            this.ImgList.Images.SetKeyName(89, "FR.png");
            this.ImgList.Images.SetKeyName(90, "GA.png");
            this.ImgList.Images.SetKeyName(91, "GB.png");
            this.ImgList.Images.SetKeyName(92, "GD.png");
            this.ImgList.Images.SetKeyName(93, "GE.png");
            this.ImgList.Images.SetKeyName(94, "GG.png");
            this.ImgList.Images.SetKeyName(95, "GH.png");
            this.ImgList.Images.SetKeyName(96, "GI.png");
            this.ImgList.Images.SetKeyName(97, "GL.png");
            this.ImgList.Images.SetKeyName(98, "GM.png");
            this.ImgList.Images.SetKeyName(99, "GN.png");
            this.ImgList.Images.SetKeyName(100, "GQ.png");
            this.ImgList.Images.SetKeyName(101, "GR.png");
            this.ImgList.Images.SetKeyName(102, "GS.png");
            this.ImgList.Images.SetKeyName(103, "GT.png");
            this.ImgList.Images.SetKeyName(104, "GU.png");
            this.ImgList.Images.SetKeyName(105, "GW.png");
            this.ImgList.Images.SetKeyName(106, "GY.png");
            this.ImgList.Images.SetKeyName(107, "HK.png");
            this.ImgList.Images.SetKeyName(108, "HN.png");
            this.ImgList.Images.SetKeyName(109, "HR.png");
            this.ImgList.Images.SetKeyName(110, "HT.png");
            this.ImgList.Images.SetKeyName(111, "HU.png");
            this.ImgList.Images.SetKeyName(112, "ID.png");
            this.ImgList.Images.SetKeyName(113, "IE.png");
            this.ImgList.Images.SetKeyName(114, "IL.png");
            this.ImgList.Images.SetKeyName(115, "IM.png");
            this.ImgList.Images.SetKeyName(116, "IN.png");
            this.ImgList.Images.SetKeyName(117, "IQ.png");
            this.ImgList.Images.SetKeyName(118, "IR.png");
            this.ImgList.Images.SetKeyName(119, "IS.png");
            this.ImgList.Images.SetKeyName(120, "IT.png");
            this.ImgList.Images.SetKeyName(121, "JE.png");
            this.ImgList.Images.SetKeyName(122, "JM.png");
            this.ImgList.Images.SetKeyName(123, "JO.png");
            this.ImgList.Images.SetKeyName(124, "JP.png");
            this.ImgList.Images.SetKeyName(125, "KE.png");
            this.ImgList.Images.SetKeyName(126, "KG.png");
            this.ImgList.Images.SetKeyName(127, "KH.png");
            this.ImgList.Images.SetKeyName(128, "KI.png");
            this.ImgList.Images.SetKeyName(129, "KM.png");
            this.ImgList.Images.SetKeyName(130, "KN.png");
            this.ImgList.Images.SetKeyName(131, "KP.png");
            this.ImgList.Images.SetKeyName(132, "KR.png");
            this.ImgList.Images.SetKeyName(133, "KV.png");
            this.ImgList.Images.SetKeyName(134, "KW.png");
            this.ImgList.Images.SetKeyName(135, "KY.png");
            this.ImgList.Images.SetKeyName(136, "KZ.png");
            this.ImgList.Images.SetKeyName(137, "LA.png");
            this.ImgList.Images.SetKeyName(138, "LB.png");
            this.ImgList.Images.SetKeyName(139, "LC.png");
            this.ImgList.Images.SetKeyName(140, "LI.png");
            this.ImgList.Images.SetKeyName(141, "LK.png");
            this.ImgList.Images.SetKeyName(142, "LR.png");
            this.ImgList.Images.SetKeyName(143, "LS.png");
            this.ImgList.Images.SetKeyName(144, "LT.png");
            this.ImgList.Images.SetKeyName(145, "LU.png");
            this.ImgList.Images.SetKeyName(146, "LV.png");
            this.ImgList.Images.SetKeyName(147, "LY.png");
            this.ImgList.Images.SetKeyName(148, "MA.png");
            this.ImgList.Images.SetKeyName(149, "MC.png");
            this.ImgList.Images.SetKeyName(150, "MD.png");
            this.ImgList.Images.SetKeyName(151, "ME.png");
            this.ImgList.Images.SetKeyName(152, "MG.png");
            this.ImgList.Images.SetKeyName(153, "MH.png");
            this.ImgList.Images.SetKeyName(154, "MK.png");
            this.ImgList.Images.SetKeyName(155, "ML.png");
            this.ImgList.Images.SetKeyName(156, "MM.png");
            this.ImgList.Images.SetKeyName(157, "MN.png");
            this.ImgList.Images.SetKeyName(158, "MO.png");
            this.ImgList.Images.SetKeyName(159, "MP.png");
            this.ImgList.Images.SetKeyName(160, "MR.png");
            this.ImgList.Images.SetKeyName(161, "MS.png");
            this.ImgList.Images.SetKeyName(162, "MT.png");
            this.ImgList.Images.SetKeyName(163, "MU.png");
            this.ImgList.Images.SetKeyName(164, "MV.png");
            this.ImgList.Images.SetKeyName(165, "MW.png");
            this.ImgList.Images.SetKeyName(166, "MX.png");
            this.ImgList.Images.SetKeyName(167, "MY.png");
            this.ImgList.Images.SetKeyName(168, "MZ.png");
            this.ImgList.Images.SetKeyName(169, "NA.png");
            this.ImgList.Images.SetKeyName(170, "NC.png");
            this.ImgList.Images.SetKeyName(171, "NE.png");
            this.ImgList.Images.SetKeyName(172, "NF.png");
            this.ImgList.Images.SetKeyName(173, "NG.png");
            this.ImgList.Images.SetKeyName(174, "NI.png");
            this.ImgList.Images.SetKeyName(175, "NL.png");
            this.ImgList.Images.SetKeyName(176, "NO.png");
            this.ImgList.Images.SetKeyName(177, "NP.png");
            this.ImgList.Images.SetKeyName(178, "NR.png");
            this.ImgList.Images.SetKeyName(179, "NU.png");
            this.ImgList.Images.SetKeyName(180, "NZ.png");
            this.ImgList.Images.SetKeyName(181, "OM.png");
            this.ImgList.Images.SetKeyName(182, "PA.png");
            this.ImgList.Images.SetKeyName(183, "PE.png");
            this.ImgList.Images.SetKeyName(184, "PG.png");
            this.ImgList.Images.SetKeyName(185, "PH.png");
            this.ImgList.Images.SetKeyName(186, "PK.png");
            this.ImgList.Images.SetKeyName(187, "PL.png");
            this.ImgList.Images.SetKeyName(188, "PN.png");
            this.ImgList.Images.SetKeyName(189, "PR.png");
            this.ImgList.Images.SetKeyName(190, "PS.png");
            this.ImgList.Images.SetKeyName(191, "PT.png");
            this.ImgList.Images.SetKeyName(192, "PW.png");
            this.ImgList.Images.SetKeyName(193, "PY.png");
            this.ImgList.Images.SetKeyName(194, "QA.png");
            this.ImgList.Images.SetKeyName(195, "RO.png");
            this.ImgList.Images.SetKeyName(196, "RS.png");
            this.ImgList.Images.SetKeyName(197, "RU.png");
            this.ImgList.Images.SetKeyName(198, "RW.png");
            this.ImgList.Images.SetKeyName(199, "SA.png");
            this.ImgList.Images.SetKeyName(200, "SB.png");
            this.ImgList.Images.SetKeyName(201, "SC.png");
            this.ImgList.Images.SetKeyName(202, "SD.png");
            this.ImgList.Images.SetKeyName(203, "SE.png");
            this.ImgList.Images.SetKeyName(204, "SG.png");
            this.ImgList.Images.SetKeyName(205, "SH.png");
            this.ImgList.Images.SetKeyName(206, "SI.png");
            this.ImgList.Images.SetKeyName(207, "SK.png");
            this.ImgList.Images.SetKeyName(208, "SL.png");
            this.ImgList.Images.SetKeyName(209, "SM.png");
            this.ImgList.Images.SetKeyName(210, "SN.png");
            this.ImgList.Images.SetKeyName(211, "SO.png");
            this.ImgList.Images.SetKeyName(212, "SR.png");
            this.ImgList.Images.SetKeyName(213, "SS.png");
            this.ImgList.Images.SetKeyName(214, "ST.png");
            this.ImgList.Images.SetKeyName(215, "SV.png");
            this.ImgList.Images.SetKeyName(216, "SY.png");
            this.ImgList.Images.SetKeyName(217, "SZ.png");
            this.ImgList.Images.SetKeyName(218, "TC.png");
            this.ImgList.Images.SetKeyName(219, "TD.png");
            this.ImgList.Images.SetKeyName(220, "TG.png");
            this.ImgList.Images.SetKeyName(221, "TH.png");
            this.ImgList.Images.SetKeyName(222, "TJ.png");
            this.ImgList.Images.SetKeyName(223, "TM.png");
            this.ImgList.Images.SetKeyName(224, "TN.png");
            this.ImgList.Images.SetKeyName(225, "TO.png");
            this.ImgList.Images.SetKeyName(226, "TP.png");
            this.ImgList.Images.SetKeyName(227, "TR.png");
            this.ImgList.Images.SetKeyName(228, "TT.png");
            this.ImgList.Images.SetKeyName(229, "TV.png");
            this.ImgList.Images.SetKeyName(230, "TW.png");
            this.ImgList.Images.SetKeyName(231, "TZ.png");
            this.ImgList.Images.SetKeyName(232, "UA.png");
            this.ImgList.Images.SetKeyName(233, "UG.png");
            this.ImgList.Images.SetKeyName(234, "US.png");
            this.ImgList.Images.SetKeyName(235, "UY.png");
            this.ImgList.Images.SetKeyName(236, "UZ.png");
            this.ImgList.Images.SetKeyName(237, "VA.png");
            this.ImgList.Images.SetKeyName(238, "VC.png");
            this.ImgList.Images.SetKeyName(239, "VE.png");
            this.ImgList.Images.SetKeyName(240, "VG.png");
            this.ImgList.Images.SetKeyName(241, "VI.png");
            this.ImgList.Images.SetKeyName(242, "VN.png");
            this.ImgList.Images.SetKeyName(243, "VU.png");
            this.ImgList.Images.SetKeyName(244, "WS.png");
            this.ImgList.Images.SetKeyName(245, "YE.png");
            this.ImgList.Images.SetKeyName(246, "YT.png");
            this.ImgList.Images.SetKeyName(247, "ZA.png");
            this.ImgList.Images.SetKeyName(248, "ZM.png");
            this.ImgList.Images.SetKeyName(249, "ZW.png");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 615);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HtmlCMS";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.ListBox lstSite;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ImageList ImgList;

    }
}

