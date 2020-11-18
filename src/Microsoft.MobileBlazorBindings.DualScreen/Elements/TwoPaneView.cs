﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public partial class TwoPaneView : Grid
    {
        [Parameter] public RenderFragment Pane1 { get; set; }
        [Parameter] public RenderFragment Pane2 { get; set; }

#pragma warning disable CA1721 // Property names should not match get methods
        protected override RenderFragment GetChildContent() => RenderChildContent;
#pragma warning restore CA1721 // Property names should not match get methods

        private void RenderChildContent(RenderTreeBuilder builder)
        {
            builder.OpenComponent<TwoPaneViewPane1>(0);
            builder.AddAttribute(0, nameof(TwoPaneViewPane1.ChildContent), Pane1);
            builder.CloseComponent();

            builder.OpenComponent<TwoPaneViewPane2>(1);
            builder.AddAttribute(0, nameof(TwoPaneViewPane2.ChildContent), Pane2);
            builder.CloseComponent();
        }
    }
}
