﻿using System;
using System.Collections.Generic;

namespace LondonTowerLibrary
{
    [Serializable]
    public class TowerOfLondon
    {
        
        private int level;
        private DateTime testDate;
        private List<Trial> trialList;
        private int trialNumber;
        private Personn personn;
        private bool visualHelp;
        private DateTime dateAndTime;
        private string fdback;

        public int Level { get => level; set => level = value; }
        public DateTime TestDate { get => testDate; set => testDate = value; }
        public List<Trial> TrialList { get => trialList; set => trialList = value; }
        public Personn Personn { get => personn; set => personn = value; }
        public bool VisualHelp { get => visualHelp; set => visualHelp = value; }
        public DateTime DateAndTime { get => dateAndTime; set => dateAndTime = value; }
        public string Fdback { get => fdback; set => fdback = value; }

        public TowerOfLondon()
        {
            trialNumber = 0;
        }
        public TowerOfLondon(int _level, List<Trial> _trialList, Personn _personn) : this()
        {
            this.level = _level;
            this.trialList = _trialList;
            this.Personn = _personn;
        }

        public Trial GetNextTrial()
        {
            if (HastNextTrial())
            {
                Trial t = trialList[trialNumber];
                trialNumber++;
                return t;
            }
            return null;
        }
        public bool HastNextTrial()
        {
            if (trialList.Count > this.trialNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
