using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dal
{
    public interface IConstrained
    {
        /// <summary>
        /// Propertija, kura nosaka, vai objektu drīkst rādīt lietotājam. Izsaucas no Get un List metodēm.
        /// </summary>
        /// <returns><c>true</c>, ja piekļuve objektam ir atļauta</returns>
        bool CanSee { get; }
        /// <summary>
        /// Propertija, kura nosaka, vai objektu drīkst saglabāt.
        /// </summary>
        /// <returns><c>true</c>, ja objektu drīkst saglabāt</returns>
        /// <remarks>
        /// Ja atgriezīs false, objektu vienkārši KLUSI nesaglabās.
        /// Tā kā reportējamu problēmu gadījumā labāk šajā funkcijā mest exceptionu.
        /// </remarks>
        bool CanSave { get; }
        /// <summary>
        /// Determines whether current object can be edited
        /// </summary>
        bool CanEdit { get; }
        /// <summary>
        /// Determines whether current object is active
        /// </summary>
        bool IsActive { get; set;}
    }
}
