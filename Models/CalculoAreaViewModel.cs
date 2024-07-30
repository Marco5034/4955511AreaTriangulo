using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4955511AreaTriangulo.Models
{
    partial class CalculoAreaViewModel: ObservableObject
    {

        [ObservableProperty]
        public string l1;
        [ObservableProperty]
        public string l2;

        [ObservableProperty]
        public string l3;

        [ObservableProperty]
        public string area;

        [RelayCommand]
        private void CalculoArea()
        {
            if (double.TryParse(L1, out double v1) && double.TryParse(L2, out double v2) && double.TryParse(L3, out double v3))
            {
                double S;

                S = (v1 + v2 + v3) / 2;
                Area = Math.Round(Math.Sqrt(S * (S - v1) * (S - v2) * (S - v3)), 2).ToString();


            }
            else
            {
                Area = "Ingrese números válidos";
            }
            }
        }
    }
