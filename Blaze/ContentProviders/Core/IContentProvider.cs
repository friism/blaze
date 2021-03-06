﻿using System;
using System.ComponentModel.Composition;
using System.Net;

namespace JabbR.ContentProviders.Core
{
    [InheritedExport]
    public interface IContentProvider
    {
        ContentProviderResultModel GetContent(Uri uri);
    }
}
