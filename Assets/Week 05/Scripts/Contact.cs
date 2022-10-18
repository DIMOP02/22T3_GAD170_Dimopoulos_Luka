using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukaDimopoulos
{
    public enum TheLads { Undefined, LeungPhatt, Batman, Yovan}

    public class Contact : MonoBehaviour
    {
        [SerializeField] private TheLads theBlacklist = TheLads.Undefined;
        [SerializeField] private string firstName;
        [SerializeField] private string lastName;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;
        [SerializeField] private string preferredName;
        [SerializeField] private string socialSecurityNumber;
        [SerializeField] private string ipAddress;

        private void Start()
        {
            // We want to set up all 3 charcters here
            // Using an if statement, we can say:
            // Use if statements
            // if variable == 0, set up Leung Phatt
            // if variable == 1, set up Batman
            // if variable == 2, set up Yovan
            //SetupLeungPhatt();
            //SetupBatman();
            //SetupYovan();

            switch (theBlacklist)
            {
                case TheLads.Undefined:
                    Debug.Log("The Lads undefined. Set its enum in the inspector!");
                    break;
                case TheLads.LeungPhatt:
                    Setup("Leung", "Phatt", "(847) 252-5700", "39 Regent St, Chippendale NSW 2008", "obama.library@nara.gov", "Arnold Schwarzenegger", "You're a loser, get a life.", "10.40.51.148");
                    break;
                case TheLads.Batman:
                    Setup("Bruce", "Willis", "LEGO 6860", "107 N. Cliffwood Avenue, Brentwood Park, USA", "alfredispapi@batmail.com", "Batboy", "Follow the bat signal.", "10.40.51.147");
                    break;
                case TheLads.Yovan:
                    Setup("Yovan", "Stankovic", "0400769420", "Bikini Bottom", "Aaronislegend@gmail.com", "Aaron Goss", "0123456789", "10.40.51.147");
                    break;
                default:
                    Debug.Log("Uh oh...");
                    break;
            }
        }

        private void Setup(string newFirstName,
                           string newLastName,
                           string newPreferredName,
                           string newPhoneNumber,
                           string newAddress,
                           string newEmail,
                           string newIpAddress,
                           string newSocialSecurityNumber)
        {
            firstName = newFirstName;
            lastName = newLastName;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
            preferredName = newPreferredName;
            socialSecurityNumber = newSocialSecurityNumber;
            ipAddress = newIpAddress;
        }
        private void SetupLeungPhatt()
        {
            firstName = "Leung";
            lastName = "Phatt";
            phoneNumber = "(847) 252-5700";
            address = "39 Regent St, Chippendale NSW 2008";
            email = "obama.library@nara.gov";
            preferredName = "Arnold Schwarzenegger";
            socialSecurityNumber = "You're a loser, get a life.";
            ipAddress = "10.40.51.148";
        }
        private void SetupBatman()
        {
            firstName = "Bruce";
            lastName = "Willis";
            phoneNumber = "LEGO 6860";
            address = "107 N. Cliffwood Avenue, Brentwood Park, USA";
            email = "alfredispapi@batmail.com";
            preferredName = "Batboy";
            socialSecurityNumber = "Follow the bat signal.";
            ipAddress = "10.40.51.147";
        }
        private void SetupYovan()
        {
            firstName = "Yovan";
            lastName = "Stankovic";
            phoneNumber = "0400769420";
            address = "Bikini Bottom";
            email = "Aaronislegend@gmail.com";
            preferredName = "Aaron Goss";
            socialSecurityNumber = "0123456789";
            ipAddress = "10.40.51.147";
        }
    }

}
    