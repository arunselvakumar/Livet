﻿//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
	/// <summary>
    /// ScrollBarVisibility列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ScrollBarVisibilityAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private ScrollBarVisibility _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのScrollBarVisibility列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ScrollBarVisibility ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private ScrollBarVisibility _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのScrollBarVisibility列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ScrollBarVisibility ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is ScrollBarVisibility)) throw new ArgumentException();

            var enumValue = (ScrollBarVisibility)value;

			switch(enumValue.ToString())
			{
				case "Disabled":
					if (_isConvertBackWhenDisabledSet)
					{
						return ConvertBackWhenDisabled;
					}
					break;
				case "Auto":
					if (_isConvertBackWhenAutoSet)
					{
						return ConvertBackWhenAuto;
					}
					break;
				case "Hidden":
					if (_isConvertBackWhenHiddenSet)
					{
						return ConvertBackWhenHidden;
					}
					break;
				case "Visible":
					if (_isConvertBackWhenVisibleSet)
					{
						return ConvertBackWhenVisible;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
		/// <summary>
        /// ScrollBarVisibilityの値をbool値に変換する際のデフォルト値を指定、または取得します。
        /// </summary>
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenDisabledSet;
        private bool _convertBackWhenDisabled;
		/// <summary>
        /// ScrollBarVisibilityの値がDisabledの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDisabled
        {
            get
            {
                return _convertBackWhenDisabled;
            }
            set
            {
                _convertBackWhenDisabled = value;
                _isConvertBackWhenDisabledSet = true;
            }
        }
        private bool _isConvertBackWhenAutoSet;
        private bool _convertBackWhenAuto;
		/// <summary>
        /// ScrollBarVisibilityの値がAutoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAuto
        {
            get
            {
                return _convertBackWhenAuto;
            }
            set
            {
                _convertBackWhenAuto = value;
                _isConvertBackWhenAutoSet = true;
            }
        }
        private bool _isConvertBackWhenHiddenSet;
        private bool _convertBackWhenHidden;
		/// <summary>
        /// ScrollBarVisibilityの値がHiddenの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHidden
        {
            get
            {
                return _convertBackWhenHidden;
            }
            set
            {
                _convertBackWhenHidden = value;
                _isConvertBackWhenHiddenSet = true;
            }
        }
        private bool _isConvertBackWhenVisibleSet;
        private bool _convertBackWhenVisible;
		/// <summary>
        /// ScrollBarVisibilityの値がVisibleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenVisible
        {
            get
            {
                return _convertBackWhenVisible;
            }
            set
            {
                _convertBackWhenVisible = value;
                _isConvertBackWhenVisibleSet = true;
            }
        }
    }
}