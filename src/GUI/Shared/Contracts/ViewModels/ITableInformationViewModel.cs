﻿using System.Collections.ObjectModel;
using RevEng.Common;

namespace EFCorePowerTools.Contracts.ViewModels
{
    public interface ITableInformationViewModel : IObjectTreeEditableViewModel, IObjectTreeSelectableViewModel, IViewModel
    {
        string Schema { get; set; }

        bool HasPrimaryKey { get; }

        ObjectType ObjectType { get; set; }

        ObjectTypeIcon ObjectTypeIcon { get; }

        ObservableCollection<IColumnInformationViewModel> Columns { get; }

        bool IsVisible { get; set; }

        string ModelDisplayName { get; set; }
    }
}