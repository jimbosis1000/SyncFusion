#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.spellcheckerdemo.wpf
{
    public class SpellCheckerDemoViewModel : DemoBrowserViewModel
    {
        public override List<ProductDemo> GetDemosDetails()
        {
            var productdemos = new List<ProductDemo>();
            productdemos.Add(new SpellCheckerProductDemos());
            return productdemos;
        }
    }

    public class SpellCheckerProductDemos : ProductDemo
    {
        public SpellCheckerProductDemos()
        {
            this.Product = "Spell Checker";
            this.ProductCategory = "MISCELLANEOUS";
            this.Demos = new List<DemoInfo>();
            this.Demos.Add(new DemoInfo() { SampleName = "Getting Started", Description= "This sample showcases the basic features of the SfSpellChecker which checks the spellings of any text such as Provide built-in spell check options, Provide suggestions through dialogue and context menu", GroupName = "SPELL CHECKER", DemoViewType = typeof(SpellCheckerDemo) });
           


        }
    }
}
