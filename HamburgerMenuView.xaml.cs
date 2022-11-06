﻿using MahApps.Metro.Controls;
using System.Windows.Controls;

namespace WpfHamburgerMenuSample;

public partial class HamburgerMenuView : UserControl
{
    public HamburgerMenuView()
    {
        DataContext = new HumburgerMenuViewModel();
        InitializeComponent();
    }

    void HamburgerMenu_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
    {
        if (sender is not HamburgerMenu hamburgerMenu)
            return;

        // If there is no content, create and set content.
        if (e.InvokedItem is HamburgerMenuItemBase item)
        {
            if (item.Tag is null)
            {
                var type = MyHamburgerMenuProperies.GetDeferredContentType(item);
                item.Tag = Activator.CreateInstance(type);
            }
        }
        hamburgerMenu.Content = e.InvokedItem;
    }
}
