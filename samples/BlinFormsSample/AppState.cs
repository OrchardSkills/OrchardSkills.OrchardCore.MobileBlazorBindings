﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Collections.Generic;
using System.Linq;

namespace BlinFormsSample
{
    public class AppState
    {
        public List<TodoItem> Items { get; } = new List<TodoItem>();

        public int Counter { get; set; }

        public void ResetAppState(bool createDefaultTodoItems)
        {
            Items.Clear();

            if (createDefaultTodoItems)
            {
                Items.AddRange(
                    new[]
                    {
                        new TodoItem { Text = "sell dog", IsDone = true },
                        new TodoItem { Text = "buy cat" },
                        new TodoItem { Text = "buy cat food" },
                    });
            }

            Counter = 0;
        }

        public bool IsEmptyAppState()
        {
            return
                !Items.Any() &&
                Counter == 0;
        }
    }
}
