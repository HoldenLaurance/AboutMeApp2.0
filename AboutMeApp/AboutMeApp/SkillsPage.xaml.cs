﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillsPage : ContentPage
    {

        public ObservableCollection<skillItem> Skills{ get; set; }
        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<skillItem>();

            skillItem drivingSkill = new skillItem();
            drivingSkill.Name= "Driving";
            drivingSkill.Icon= "";

            skillItem readingSkill = new skillItem();
            readingSkill.Name = "Reading";
            readingSkill.Icon = "";

            skillItem catSkill = new skillItem();
            catSkill.Name = "Loving Cats";
            catSkill.Icon = "";

            skillItem typingSkill = new skillItem();
            typingSkill.Name = "Typing";
            typingSkill.Icon = "";

            skillItem cookingSkill = new skillItem();
            cookingSkill.Name = "Cooking";
            cookingSkill.Icon = "";

            Skills.Add(drivingSkill);
            Skills.Add(readingSkill);
            Skills.Add(catSkill);
            Skills.Add(typingSkill);
            Skills.Add(cookingSkill);

            skillsList.ItemsSource = this.Skills;
        }

        
    }
}