﻿using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using LondonTowerLibrary.Properties;
using LondonTowerLibrary.ViewModels;
using Newtonsoft.Json;


namespace LondonTowerLibrary
{
    public class FactoryLondonTower
    {

        public static TowerOfLondon GetTowerOfLondon(LondonTowerVM towerVM)
        {


            TowerOfLondon ToL = LoadTowerOfLondon<TowerOfLondon>(towerVM.NbPegs);
            ToL.DateAndTime = towerVM.DateAndTime;
            ToL.Personn = towerVM.Personne;
            ToL.VisualHelp = towerVM.VisualHelp;

            return ToL;
        }

        private static T LoadTowerOfLondon<T>(int level)
        {
           string path = "./Config/TowerOfLondon_Lvl" + level + ".txt";
           var str = File.ReadAllText(path);
            T Tempo = JsonConvert.DeserializeObject<T>(str);
            return Tempo;
        }

        public static void SaveTowerOfLondon(TowerOfLondon _t)
        {
            string path = "pack://application:,,,/Component/Resources/Config/TowerOfLondon_Lvl" + _t.Level + "_save.txt";
            string str = JsonConvert.SerializeObject(_t, Formatting.Indented);
            File.WriteAllText(path, str);
        }

        //private static void SaveTn(TowerOfLondon _t)
        //{
        //    string path = "./ConfigTower/Tower" + _t.Level + "_save.txt";
        //    string str = JsonConvert.SerializeObject(_t, Formatting.Indented);
        //    File.WriteAllText(path, str);
        //}

   
        private static Bead CreateBead(ColorEnum color)
        {
            return new Bead(color);
        }

        private static Peg CreatePeg(int _PegNumber)
        {
            return new Peg(_PegNumber);
        }

        private static List<Peg> InitListStart()
        {
            List<Peg> listStartPos;
            Peg peg5 = CreatePeg(5);
            peg5.AddBead(CreateBead(ColorEnum.Blue));
            peg5.AddBead(CreateBead(ColorEnum.Yellow));
            peg5.AddBead(CreateBead(ColorEnum.Orange));
            peg5.AddBead(CreateBead(ColorEnum.Green));
            peg5.AddBead(CreateBead(ColorEnum.Pink));


            Peg peg4 = CreatePeg(4);


            Peg peg3 = CreatePeg(3);


            Peg peg2 = CreatePeg(2);


            Peg peg1 = CreatePeg(1);


            listStartPos = new List<Peg>();
            listStartPos.Add(peg1);
            listStartPos.Add(peg2);
            listStartPos.Add(peg3);
            listStartPos.Add(peg4);
            listStartPos.Add(peg5);

            return listStartPos;
        }

        private static List<Peg> InitListGoalPosition()
        {
            List<Peg> listStartPos;
            Peg peg5 = CreatePeg(5);
            peg5.AddBead(CreateBead(ColorEnum.Blue));

            Peg peg4 = CreatePeg(4);
            peg4.AddBead(CreateBead(ColorEnum.Yellow));

            Peg peg3 = CreatePeg(3);
            peg3.AddBead(CreateBead(ColorEnum.Orange));

            Peg peg2 = CreatePeg(2);
            peg2.AddBead(CreateBead(ColorEnum.Green));

            Peg peg1 = CreatePeg(1);
            peg1.AddBead(CreateBead(ColorEnum.Pink));

            listStartPos = new List<Peg>();
            listStartPos.Add(peg1);
            listStartPos.Add(peg2);
            listStartPos.Add(peg3);
            listStartPos.Add(peg4);
            listStartPos.Add(peg5);

            return listStartPos;
        }


    }
}
