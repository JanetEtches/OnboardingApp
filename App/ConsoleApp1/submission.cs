using System;
using System.Collections.Generic;
using System.Text;

namespace Onboarding
{
    /// <summary>
    /// This class represents basic submission information, 
    /// e.g. who is submitting a request, who owns the request 
    /// and various properties.
    /// </summary>
    class submission
    {
        #region Properties

        public int Index { get; private set; }
        public String Title { get; set; }
        public string User { get; set; }
        public string SourceLocation { get; set; }
        public string TargetLocation { get; set; }
        public string Owner { get; private set; }
        public DateTime CreateDate { get; }
        public DateTime ClosedDate { get; private set; }
        public string Status { get; private set; }

        #endregion

        #region Methods

        ///<summary
        ///Set Sumbission ID
        /// </summary>
        /// <param name="ItemID"> Submission ID</param>
        /// <returns>Submission ID</returns> 
        public int ItemID(int ItemID)
        {

            Index = Index++;
            return Index;
        }

        /// <summary>
        /// Change Owner of request
        /// </summary>
        /// <param name="NewOwner">New Owner of request</param>
        /// <returns>New Owner name</returns> 
        public string ChangeOwner(string NewOwner)
        {

            Owner = NewOwner;
            return Owner;
        }
        /// <summary>
        /// Set User
        /// </summary>
        /// <param name="">User</param>
        /// <returns>User</returns> 
        public string ChangeUser(string NewUser)
        {

            User = NewUser;
            return User;
        }


        /// <summary>
        /// Change Source Location
        /// </summary>
        /// <param name="">Source Location</param>
        /// <returns>ChangeSource</returns> 
        public string ChangeSource(string NewSource)
        {

            SourceLocation = NewSource;
            return SourceLocation;
        }
    }
    #endregion
}
