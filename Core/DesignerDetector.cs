using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.ComponentModel.Design;

namespace Core
{
    /// <summary>
    /// Статический класс, предназначенный для распознавания режима работы -
    /// design-time/run-time.</summary>
    /// <remarks>Этот класс написан по причине того, что в некоторых случаях, когда форма (компонент) создается
    /// в дизайнере, нельзя определить режим (поскольку <see cref="IComponent.Site"/> равен null).</remarks>
    public sealed class DesignerDetector
    {
        #region Const
        /// <summary>
        /// Номер фрейма стека, начиная с которого ищем <see cref="sm_Interface_Match"/>.</summary>
        /// <remarks>Чем больше число, тем быстрее будем искать (но менее надежно).</remarks>
        private const int START_FRAME = 4;
        #endregion // Const
        #region Static
        #region Fields
        /// <summary>
        /// В методе <see cref="IsComponentInDesignMode"/> происходит
        /// поиск по стеку вызовов типа, который реализует данный интерфейс (<see cref="IDesignerHost"/>).</summary>
        private static readonly Type sm_Interface_Match = typeof(IDesignerHost);
        [ThreadStatic()]
        private static bool? sm_KnownResult; 
        #endregion // Fields
        #region Methods
        /// <summary>
        /// Проверяет, находится ли компонент в режиме дизайна.</summary>
        /// <param name="component">Компонент.</param>
        /// <returns>true, если компонент открыт в дизайнере.</returns>
        /// <remarks>В этом методе происходит
        /// поиск по стеку вызовов типа, который реализует интерфейс (<see cref="sm_Interface_Match"/>).</remarks>
        public static bool IsComponentInDesignMode(IComponent component)
        {
            if (!sm_KnownResult.HasValue)
            {
                sm_KnownResult = Orig_IsComponentInDesignMode(component);
            }
            return sm_KnownResult.Value;
        }
        private static bool Orig_IsComponentInDesignMode(IComponent component)
        {
            // вдруг все просто?
            if (component.Site != null)
            {
                return component.Site.DesignMode;
            }
            // теперь все уже не так просто...
            StackTrace _stackTrace = new StackTrace();
            int _iFrameCount = _stackTrace.FrameCount - 1;
            // пробегаем стек вызовов, пока не найдем тип, реализующий интерфейс IDesignerHost
            for (int _iFrame = START_FRAME; _iFrame < _iFrameCount; _iFrame++)
            {
                Type _type_FromStack = _stackTrace.GetFrame(_iFrame).GetMethod().DeclaringType;
                if (sm_Interface_Match.IsAssignableFrom(_type_FromStack))
                {
                    return true;
                }
            }
//#if DEBUG
//            Debug.WriteLine(String.Format("{0} frames traversed...", _iFrameCount), "DESIGNER_DETECTOR");
//            Debug.WriteLine(_stackTrace.GetFrame(2).GetMethod().DeclaringType.Name, "DESIGNER_DETECTOR");
//            Debug.WriteLine(_stackTrace.GetFrame(3).GetMethod().DeclaringType.Name, "DESIGNER_DETECTOR");
//#endif
            // маленький стек вызовов или отсутствие IDesignerHost не характерно для дизайнеров
            return false;
        }
        #endregion // Methods
        #endregion // Static
        #region Constructors
        /// <summary>
        /// Предотвращает создание экземпляра класса.</summary>
        private DesignerDetector()
        {
        }
        #endregion // Constructors
    } // DesignerDetector
}
