﻿using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ursa.Controls
{
    public class Skeleton : ContentControl
    { 

        public static readonly StyledProperty<bool> IsActiveProperty =
            AvaloniaProperty.Register<Skeleton, bool>(nameof(IsActive)); 
        public bool IsActive
        {
            get { return GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        } 
    }
}
