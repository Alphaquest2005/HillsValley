﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace SalesRegion
{
    public class SalesRegionModule : IModule
    {
        private readonly IUnityContainer container;
        private readonly IRegionManager regionManager;

        public SalesRegionModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterViews();
        }

        private void RegisterViews()
        {
            // Register the view we know of
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(SalesView));
        }
    }
}
