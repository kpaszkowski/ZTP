using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.ViewModel
{
    public class HistoricalRecords : ClubComponent, INotifyPropertyChanged
    {
        private HistoricalRecords instance;

        private HistoricalRecords() { }

        public HistoricalRecords getInstance()
        {
            if (instance == null) instance = new HistoricalRecords();
            return instance;
        }

        private String bestScorerName;
        public String getBestScorerName() { return bestScorerName; }
        public void setBestScorerName(String newName) { bestScorerName = newName; }

        private int bestScorerGoals;
        public int getBestScorerGoals() { return bestScorerGoals; }
        public void setBestScorerGoals(int newGoals) { bestScorerGoals = newGoals; }

        private String mostAppearancesName;
        public String getMostAppearancesName() { return mostAppearancesName; }
        public void setMostAppearancesName(String newName) { mostAppearancesName = newName; }

        private int mostAppearancesAmount;
        public int getMostAppearancesAmount() { return mostAppearancesAmount; }
        public void setMostAppearancesAmount(int newAmount) { mostAppearancesAmount = newAmount; }

        private String mostWinsTeam;
        public String getMostWinsTeam() { return mostWinsTeam; }
        public void setMostWinsTeam(String newTeam) { mostWinsTeam = newTeam; }

        private int mostWinsAmount;

        public event PropertyChangedEventHandler PropertyChanged;

        public int getMostWinsAmount() { return mostWinsAmount; }
        public void setMostWinsAmount(int newAmount) { mostWinsAmount = newAmount; }
    }
}
