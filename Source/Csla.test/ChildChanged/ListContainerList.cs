﻿//-----------------------------------------------------------------------
// <copyright file="ListContainerList.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>no summary</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Serialization;

namespace Csla.Test.ChildChanged
{
  [Serializable]
  public class ListContainerList : BusinessBindingListBase<ListContainerList, ContainsList>
  {
  }
}