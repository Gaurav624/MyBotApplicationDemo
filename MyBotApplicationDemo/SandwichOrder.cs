﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.FormFlow;

namespace MyBotApplicationDemo
{
    
    public enum SandwichOptions
    {
        BLT, BlackForestHam, BuffaloChicken, ChickenAndBaconRanchMelt, ColdCutCombo, MeatballMarinara,
        OvenRoastedChicken, RoastBeef, RotisserieStyleChicken, SpicyItalian, SteakAndCheese, SweetOnionTeriyaki, Tuna,
        TurkeyBreast, Veggie
    };
    public enum LengthOptions { SixInch, FootLong };
    public enum BreadOptions { NineGrainWheat, NineGrainHoneyOat, Italian, ItalianHerbsAndCheese, Flatbread };
    public enum CheeseOptions { American, MontereyCheddar, Pepperjack };
    public enum ToppingOptions
    {
        Avocado, BananaPeppers, Cucumbers, GreenBellPeppers, Jalapenos,
        Lettuce, Olives, Pickles, RedOnion, Spinach, Tomatoes
    };
    public enum SauceOptions
    {
        ChipotleSouthwest, HoneyMustard, LightMayonnaise, RegularMayonnaise,
        Mustard, Oil, Pepper, Ranch, SweetOnion, Vinegar
    };

    /// <summary>
    /// Class Sanwich Order Example for form flow in the BOT framwork
    /// </summary>
    /// 
    [Serializable]
    public class SandwichOrder
    {
        [Prompt("What kind of {&} would you like ? {||}", ChoiceFormat ="{1}")]
        public SandwichOptions? Sandwich;
        public LengthOptions? Length;
        public BreadOptions? Bread;
        [Optional]
        public CheeseOptions? Cheese;
        public List<ToppingOptions> Toppings;
        public List<SauceOptions> Sauce;
        public static IForm<SandwichOrder> BuildForm()
        {
            return new FormBuilder<SandwichOrder>()
                    .Message("Welcome to the simple sandwich order bot!")
                    .Build();
        }
    }
}
