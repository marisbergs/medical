using System.Collections.Generic;

namespace Core.Dal
{
    /// <summary>
    /// <seealso cref="NHibernate.ISession" /> papildinājumi ar loģiskās tranzakcijas elementiem.
    /// </summary>
    public interface ISession : NHibernate.ISession
    {
        /// <summary>
        /// Izveido NHibernate.ICriteria, balstoties uz nodoto <seealso cref="Expressions.CriterionBase"/> sarakstu.
        /// </summary>
        /// <typeparam name="T">Mapota klase, kuri bûvē kritērijus</typeparam>
        /// <param name="criteria"><seealso cref="Expressions.CriterionBase"/> saraksts vai null.</param>
        /// <returns></returns>
        NHibernate.ICriteria CreateAndBuildCriteria<T>(IList<Expressions.CriterionBase> criteria);
        /// <summary>
        /// Saglabā sessijā veiktās izmaiņas.
        /// </summary>
        /// <remarks>
        /// Neveiksmes (exception) gadījumā dati nebûs saglabāti, bet izmaiņas arī vēl nebûs zudušas.
        /// Pēc datu koriģēšanas varēs atkal mēģināt Commit() izsaukumu.
        /// </remarks>
        void Commit();
        /// <summary>
        /// Obsolete! Simple Commit() will do.
        /// Saglabā sessijā veiktās izmaiņas.
        /// Veiksmes gadījumā atjauno mainīto objektu datus arī <paramref name="partner"/> sessijā.
        /// </summary>
        /// <param name="partner">Partnera sessija</param>
        /// <remarks>
        /// Neveiksmes (exception) gadījumā dati nebûs saglabāti, bet izmaiņas arī vēl nebûs zudušas.
        /// Pēc datu koriģēšanas varēs atkal mēģināt Commit() izsaukumu.
        /// </remarks>
        void Commit(ISession partner);
        /// <summary>
        /// Atceļ sessijā veiktās izmaiņas.
        /// </summary>
        void Rollback();
        /// <summary>
        /// Atceļ sessijā veiktās izmaiņas.
        /// </summary>
        event Core.Dal.Session.AfterRefreshEventDelegate AfterRefresh;
    }
}
