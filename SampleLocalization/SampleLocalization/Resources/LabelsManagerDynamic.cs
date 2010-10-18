using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Linq.Expressions;

namespace SampleLocalization.Resources
{
    public class LabelsManagerDynamic : INotifyPropertyChanged
    {
        private Labels labels;

        public Labels Labels
        {
            get { return labels; }           
        }

        public LabelsManagerDynamic()
        {
            labels = new Labels();
        }

        public void ResetResources()
        {
            OnPropertyChanged(() => Labels);
        }


        #region INotifyPropertyChanged region
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged<T>(Expression<Func<T>> selector)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(GetPropertyNameFromExpression(selector)));
            }
        }

        public static string GetPropertyNameFromExpression<T>(Expression<Func<T>> property)
        {
            var lambda = (LambdaExpression)property;
            MemberExpression memberExpression;

            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression)lambda.Body;
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            else
            {
                memberExpression = (MemberExpression)lambda.Body;
            }

            return memberExpression.Member.Name;
        }
        #endregion
    }
}
