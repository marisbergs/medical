using System.Security.Principal;
using Entities;

/// <summary>
/// Summary description for Identity
/// </summary>
public class Identity : IIdentity
{
    private string name;

    public Identity(Patient user)
	{
        name = user.Name;
	}

    ///<summary>
    ///Gets the name of the current user.
    ///</summary>
    ///
    ///<returns>
    ///The name of the user on whose behalf the code is running.
    ///</returns>
    ///
    public string Name
    {
        get { return name; }
    }

    ///<summary>
    ///Gets the type of authentication used.
    ///</summary>
    ///
    ///<returns>
    ///The type of authentication used to identify the user.
    ///</returns>
    ///
    public string AuthenticationType
    {
        get { return "Custom Authentication"; }
    }

    ///<summary>
    ///Gets a value that indicates whether the user has been authenticated.
    ///</summary>
    ///
    ///<returns>
    ///true if the user was authenticated; otherwise, false.
    ///</returns>
    ///
    public bool IsAuthenticated
    {
        get { return true; }
    }
}
