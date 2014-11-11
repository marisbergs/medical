using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Core.Dal
{
    public enum ConflictResolution
    {
        Abort,
        Proceed,
        ProceedAll
    }

    public interface ISynchronizable
    {
        int Version { get; set; }
        Guid? Source { get; set; }
        /// <summary>
        /// Collects changed entities, cascading down to children
        /// </summary>
        /// <param name="target"></param>
        void CollectChangedItems(System.Collections.Queue items, Expressions.CriterionBase condition, bool stopAtFirst, ArrayList syncRootObjects);
    }

    public interface ISynchronizesSeparately
    {
    }

}
