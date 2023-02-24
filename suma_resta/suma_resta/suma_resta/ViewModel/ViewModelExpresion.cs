using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using suma_resta.Models;

namespace suma_resta.ViewModel
{
  public  class ViewModelExpresion : INotifyPropertyChanged
    {

        public ViewModelExpresion() {

            sumar = new Command(() =>
            {
                Expresion s = new Expresion()
                {
                    num1 = this.num1,
                    num2 = this.num2,
                };

                Resultado = s.ToString();

            });

            restar = new Command(() =>
            {
                Expresion r = new Expresion()
                {
                    num1 = this.num1,
                    num2 = this.num2,
                };

                Resultador = r.ToString();

            });

            multiplicar = new Command(() =>
            {
                Expresion m = new Expresion()
                {
                    num1 = this.num1,
                    num2 = this.num2,
                };

                Resultador = m.ToString();

            });
            dividir = new Command(() =>
            {
                Expresion d = new Expresion()
                {
                    num1 = this.num1,
                    num2 = this.num2,
                };

                Resultador = d.ToString();

            });

        }

        string resultado;
        public string Resultado
        {
            get => resultado;
            set
            {
                resultado = value;
                var args = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, args);
            }
        }

        string resultador;
        public string Resultador
        {
            get => resultador;
            set
            {
                resultador = value;
                var args = new PropertyChangedEventArgs(nameof(Resultador));
                PropertyChanged?.Invoke(this, args);
            }
        }



        int num1;
        public int Num1
        {
            get => num1;
            set
            {
                num1 = value;
                var args = new PropertyChangedEventArgs(nameof(Num1));
                PropertyChanged?.Invoke(this, args);
            }
        }

        int num2;
        public int Num2
        {
            get => num2;
            set
            {
                num2 = value;
                var args = new PropertyChangedEventArgs(nameof(Num2));
                PropertyChanged?.Invoke(this, args);
            }
        }

        

        public Command sumar { get; }
        public Command restar { get; }
        public Command multiplicar { get; }
        public Command dividir { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
