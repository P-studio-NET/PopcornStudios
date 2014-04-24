﻿using AircraftDataAnalysisWinRT.Common;
using AircraftDataAnalysisWinRT.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftDataAnalysisWinRT.DataModel
{
    public class StatReportSelectViewModel : BindableBase
    {
        public StatReportSelectViewModel(StatReportViewModel rootViewModel)
        {
            this.rootViewModel = rootViewModel;
            this.m_command = new RefreshCommand(this.rootViewModel);
            this.m_Months = new ObservableCollection<MonthSelectViewModelItem>();
            this.m_aircrafts = new ObservableCollection<AircraftSelectViewModelItem>();
            this.m_Years = new ObservableCollection<YearSelectViewModelItem>();

            m_Years.Add(new AllYearSelectViewModelItem());

            int year = ServerHelper.GetEarliestYear(ApplicationContext.Instance.CurrentAircraftModel);
            for (int i = year; i <= DateTime.Now.Year; i++)
            {
                m_Years.Add(new YearSelectViewModelItem() { Year = i, Display = string.Format("{0}年", i) });
            }

            this.m_Months.Add(new AllMonthSelectViewModelItem());
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 1, Display = "1月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 2, Display = "2月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 3, Display = "3月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 4, Display = "4月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 5, Display = "5月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 6, Display = "6月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 7, Display = "7月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 8, Display = "8月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 9, Display = "9月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 10, Display = "10月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 11, Display = "11月" });
            this.m_Months.Add(new MonthSelectViewModelItem() { Month = 12, Display = "12月" });

            this.m_aircrafts.Add(new AllFlightSelectViewModelItem(this));

            var aircrafts = ServerHelper.GetAllAircrafts(ApplicationContext.Instance.CurrentAircraftModel);
            if (aircrafts != null && aircrafts.Count() > 0)
            {
                foreach (var air in aircrafts)
                {
                    this.m_aircrafts.Add(new AircraftSelectViewModelItem(this) { AircraftNumber = air.AircraftNumber });
                }
            }
        }

        private YearSelectViewModelItem m_selectedYear = null;
        public YearSelectViewModelItem SelectedYear
        {
            get
            {
                return m_selectedYear;
            }
            set
            {
                this.SetProperty<YearSelectViewModelItem>(ref m_selectedYear, value);
            }
        }

        private ObservableCollection<YearSelectViewModelItem> m_Years = null;

        public ObservableCollection<YearSelectViewModelItem> Years
        {
            get { return m_Years; }
            set { this.SetProperty<ObservableCollection<YearSelectViewModelItem>>(ref m_Years, value); }
        }

        private MonthSelectViewModelItem m_selectedMonth = null;

        public MonthSelectViewModelItem SelectedMonth
        {
            get
            {
                return m_selectedMonth;
            }
            set
            {
                this.SetProperty<MonthSelectViewModelItem>(ref m_selectedMonth, value);
            }
        }

        private ObservableCollection<MonthSelectViewModelItem> m_Months = null;

        public ObservableCollection<MonthSelectViewModelItem> Months
        {
            get { return m_Months; }
            set { this.SetProperty<ObservableCollection<MonthSelectViewModelItem>>(ref m_Months, value); }
        }

        private ObservableCollection<AircraftSelectViewModelItem> m_aircrafts = null;

        private StatReportViewModel rootViewModel;

        public ObservableCollection<AircraftSelectViewModelItem> Aircrafts
        {
            get { return m_aircrafts; }
            set
            {
                this.SetProperty<ObservableCollection<AircraftSelectViewModelItem>>(ref m_aircrafts, value);
            }
        }

        private RefreshCommand m_command = null;

        public System.Windows.Input.ICommand Refresh
        {
            get
            {
                return m_command;
            }
        }

        class RefreshCommand : System.Windows.Input.ICommand
        {
            public RefreshCommand(StatReportViewModel rootViewModel)
            {
                this.rootViewModel = rootViewModel;
            }

            public bool CanExecute(object parameter)
            {
                if (rootViewModel != null && rootViewModel.SelectModel != null)
                {
                    string validResult = rootViewModel.SelectModel.ValidateSelected();

                    if (string.IsNullOrEmpty(validResult))
                        return true;
                }
                return false;
            }

            public event EventHandler CanExecuteChanged;

            private StatReportViewModel rootViewModel;

            public void Execute(object parameter)
            {
                this.rootViewModel.RefreshData();
            }
        }

        internal string ValidateSelected()
        {
            return string.Empty;
        }
    }

    public class AircraftSelectViewModelItem : BindableBase
    {
        public AircraftSelectViewModelItem(StatReportSelectViewModel selectModel)
        {
            this.selectModel = selectModel;
        }

        private bool m_isSelected = false;
        public virtual bool IsSelected
        {
            get { return m_isSelected; }
            set
            {
                this.SetProperty<bool>(ref m_isSelected, value);

                if (this.selectModel != null && this.selectModel.Aircrafts.Count > 0
                    && this.selectModel.Aircrafts[0] is AllFlightSelectViewModelItem)
                {
                    (this.selectModel.Aircrafts[0] as AllFlightSelectViewModelItem).OnPropertyChanged("IsSelected");
                }
            }
        }

        private string m_AircraftNumber = string.Empty;

        public string AircraftNumber
        {
            get
            {
                return this.m_AircraftNumber;
            }
            set
            {
                this.SetProperty<string>(ref m_AircraftNumber, value);
            }
        }

        //private string m_flightID = string.Empty;
        protected StatReportSelectViewModel selectModel;

        //public string FlightID
        //{
        //    get { return m_flightID; }
        //    set
        //    {
        //        this.SetProperty<string>(ref m_flightID, value);
        //    }
        //}
    }

    public class AllFlightSelectViewModelItem : AircraftSelectViewModelItem
    {
        public AllFlightSelectViewModelItem(StatReportSelectViewModel selectModel)
            : base(selectModel)
        {
            //this.FlightID = string.Empty;
            this.AircraftNumber = "(全部)";
        }

        public override bool IsSelected
        {
            get
            {
                if (this.selectModel != null)
                {
                    if (this.selectModel.Aircrafts.Count > 1)
                    {
                        foreach (var m in this.selectModel.Aircrafts)
                        {
                            if (m is AllFlightSelectViewModelItem)
                                continue;
                            if (m.IsSelected == false)
                                return false;
                        }
                        return true;
                    }
                }
                return base.IsSelected;
            }
            set
            {
                if (this.selectModel != null)
                {
                    foreach (var m in this.selectModel.Aircrafts)
                    {
                        if (m == this)
                        {
                            base.IsSelected = value;
                            continue;
                        }
                        m.IsSelected = value;
                    }
                }
            }
        }
    }

    public class YearSelectViewModelItem
    {
        public virtual string Display
        {
            get;
            set;
        }

        public virtual int Year
        {
            get;
            set;
        }
    }

    public class AllYearSelectViewModelItem : YearSelectViewModelItem
    {
        public override string Display
        {
            get
            {
                return "全部";//return base.Display;
            }
            set
            {
                //base.Display = value;
            }
        }

        public override int Year
        {
            get
            {
                return -1;
                //return base.Year;
            }
            set
            {
                //base.Year = value;
            }
        }
    }

    public class MonthSelectViewModelItem
    {
        public virtual string Display
        {
            get;
            set;
        }

        public virtual int Month
        {
            get;
            set;
        }
    }

    public class AllMonthSelectViewModelItem : MonthSelectViewModelItem
    {
        public override string Display
        {
            get
            {
                return "全年";//return base.Display;
            }
            set
            {
                //base.Display = value;
            }
        }

        public override int Month
        {
            get
            {
                return -1;
                //return base.Year;
            }
            set
            {
                //base.Year = value;
            }
        }
    }
}
