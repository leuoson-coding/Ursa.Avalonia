﻿using System;
using Avalonia.Controls.Notifications;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Notification = Ursa.Controls.Notification;
using WindowNotificationManager = Ursa.Controls.WindowNotificationManager;

namespace Ursa.Demo.ViewModels;

public partial class NotificationDemoViewModel : ObservableObject
{
    public WindowNotificationManager? NotificationManager { get; set; }

    [ObservableProperty] private bool _showClose = true;

    [RelayCommand]
    public void ShowNormal(object obj)
    {
        if (obj is string s)
        {
            Enum.TryParse<NotificationType>(s, out var notificationType);
            NotificationManager?.Show(
                new Notification("Welcome", "This is message"),
                showClose: ShowClose,
                type: notificationType);
        }
    }

    [RelayCommand]
    public void ShowLight(object obj)
    {
        if (obj is string s)
        {
            Enum.TryParse<NotificationType>(s, out var notificationType);
            NotificationManager?.Show(
                new Notification("Welcome", "This is message"),
                showClose: ShowClose,
                type: notificationType,
                classes: ["Light"]);
        }
    }
}