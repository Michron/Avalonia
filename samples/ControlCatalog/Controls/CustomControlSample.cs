using Avalonia;
using Avalonia.Controls.Primitives;

namespace ControlCatalog.Controls
{
    public class CustomControlSample : TemplatedControl
    {
        public static readonly DirectProperty<CustomControlSample, string> EmptyStringProperty =
            AvaloniaProperty.RegisterDirect<CustomControlSample, string>(nameof(EmptyString), sample => sample.EmptyString);

        public static readonly DirectProperty<CustomControlSample, string> NonEmptyStringProperty =
            AvaloniaProperty.RegisterDirect<CustomControlSample, string>(nameof(NonEmptyString), sample => sample.NonEmptyString);

        public static readonly DirectProperty<CustomControlSample, bool> TrueBoolProperty =
            AvaloniaProperty.RegisterDirect<CustomControlSample, bool>(nameof(TrueBool), sample => sample.TrueBool);

        public static readonly DirectProperty<CustomControlSample, bool> FalseBoolProperty =
            AvaloniaProperty.RegisterDirect<CustomControlSample, bool>(nameof(FalseBool), sample => sample.FalseBool);

        public string EmptyString => string.Empty;
        public string NonEmptyString => nameof(NonEmptyString);
        public bool TrueBool => true;
        public bool FalseBool => false;

        public CustomControlSample()
        {
        }
    }
}
