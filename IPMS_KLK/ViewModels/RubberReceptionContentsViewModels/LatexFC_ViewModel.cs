using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace IPMS_KLK.ViewModels.RubberReceptionContentsViewModels
{
    public class LatexFC_ViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private LatexFC_TappingType _selectedTappingType { get; set; }
        public LatexFC_TappingType SelectedTappingType
        {
            get { return _selectedTappingType; }
            set
            {
                if (_selectedTappingType != value)
                {
                    _selectedTappingType = value;
                    if (_selectedTappingType.TypeKey == 4)
                    {
                        IsMethodPickerEnabled = true;
                    }
                    OnPropertyChanged();
                    
                }
            }
        }

        private bool _isMethodPickerEnabled { get; set; }
        public bool IsMethodPickerEnabled
        {
            get { return _isMethodPickerEnabled; }

            set
            {
                if (_selectedTappingType.TypeKey!=4)
                {
                    _isMethodPickerEnabled = false;
                    OnPropertyChanged();
                }
            }
        }

        

        public List<LatexFC_TappingType> tappingTypeList { get; set; }
        public List<LatexFC_Method> methodList { get; set; }
         

        public LatexFC_ViewModel() //Constructor
        {
            tappingTypeList = GetTappingTypes().OrderBy(t => t.TappingType).ToList();
            methodList = GetMethod().OrderBy(t => t.TappingMethod).ToList(); 
        }

       

        public List<LatexFC_TappingType> GetTappingTypes()
        {
            var _tappingType = new List<LatexFC_TappingType>()
            {
                new LatexFC_TappingType(){TypeKey=1, TappingType="Normal"},
                new LatexFC_TappingType(){TypeKey=2, TappingType="Evening Collection"},
                new LatexFC_TappingType(){TypeKey=3, TappingType="Late Tapping"},
                new LatexFC_TappingType(){TypeKey=4, TappingType="Recovery"},
                new LatexFC_TappingType(){TypeKey=5, TappingType="Washout"},
            };
            return _tappingType;
        } //List of tapping types

        public List<LatexFC_Method> GetMethod()
        {
            var _method = new List<LatexFC_Method>()
            {
                new LatexFC_Method(){MethodKey=1, TappingMethod="Normal + 2nd Task"},
                new LatexFC_Method(){MethodKey=2, TappingMethod="2nd Task Only"},                
            };
            return _method;
        } 
    }   

    public class LatexFC_TappingType
    {
        public int TypeKey { get; set; }
        public string TappingType { get; set; }
    }

    public class LatexFC_Method
    {
        public int MethodKey { get; set; }
        public string TappingMethod { get; set; }
    }
}
