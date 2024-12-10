using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows;

namespace CerebraPrime.Helpers
{
    public class GridLengthAnimation : AnimationTimeline
    {
        public static readonly DependencyProperty FromProperty =
            DependencyProperty.Register(nameof(From), typeof(GridLength), typeof(GridLengthAnimation));

        public static readonly DependencyProperty ToProperty =
            DependencyProperty.Register(nameof(To), typeof(GridLength), typeof(GridLengthAnimation));

        public GridLength? From
        {
            get => (GridLength?)GetValue(FromProperty);
            set => SetValue(FromProperty, value);
        }

        public GridLength? To
        {
            get => (GridLength?)GetValue(ToProperty);
            set => SetValue(ToProperty, value);
        }

        // Добавляем поддержку EasingFunction
        public IEasingFunction EasingFunction { get; set; }

        public override Type TargetPropertyType => typeof(GridLength);

        protected override Freezable CreateInstanceCore()
        {
            return new GridLengthAnimation();
        }

        public override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock)
        {
            if (From == null || To == null)
            {
                return defaultOriginValue;
            }

            double fromValue = From.Value.Value;
            double toValue = To.Value.Value;

            // Интерполяция с использованием EasingFunction, если она указана
            double progress = animationClock.CurrentProgress ?? 0.0;
            if (EasingFunction != null)
            {
                progress = EasingFunction.Ease(progress);
            }

            double currentValue = fromValue + (toValue - fromValue) * progress;
            return new GridLength(currentValue, From.Value.GridUnitType);
        }
    }
}
