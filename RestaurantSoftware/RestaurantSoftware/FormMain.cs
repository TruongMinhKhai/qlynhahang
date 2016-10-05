﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;

namespace RestaurantSoftware
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            InitSkinGallery();
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(ribbonGallery, true);
        }
    }
}
