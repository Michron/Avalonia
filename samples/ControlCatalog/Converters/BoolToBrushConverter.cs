using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace ControlCatalog.Converters
{
    /// <summary>
    /// Converts boolean values to a brush.
    /// </summary>
    public class BoolToBrushConverter : AvaloniaObject, IValueConverter
    {
        /// <summary>
        /// Defines the <see cref="FalseBrush"/> property.
        /// </summary>
        public static readonly DirectProperty<BoolToBrushConverter, IBrush> FalseBrushProperty =
            AvaloniaProperty.RegisterDirect<BoolToBrushConverter, IBrush>(
                nameof(FalseBrush),
                o => o.FalseBrush,
                (o, v) => o.FalseBrush = v);

        /// <summary>
        /// Defines the <see cref="TrueBrush"/> property.
        /// </summary>
        public static readonly DirectProperty<BoolToBrushConverter, IBrush> TrueBrushProperty =
            AvaloniaProperty.RegisterDirect<BoolToBrushConverter, IBrush>(
                nameof(TrueBrush),
                o => o.TrueBrush,
                (o, v) => o.TrueBrush = v);

        private IBrush _falseBrush;
        private IBrush _trueBrush;

        /// <summary>
        /// Brush used when value is <see langword="false"/>.
        /// </summary>
        public IBrush FalseBrush
        {
            get => _falseBrush;
            set => SetAndRaise(FalseBrushProperty, ref _falseBrush, value);
        }

        /// <summary>
        /// Brush used when value is <see langword="true"/>.
        /// </summary>
        public IBrush TrueBrush
        {
            get => _trueBrush;
            set => SetAndRaise(TrueBrushProperty, ref _trueBrush, value);
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null || !(bool)value)
            {
                return FalseBrush;
            }

            return TrueBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
