using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD_DATA;
using MOD_BAL;
using NUnit;
using NUnit.Framework;
namespace MOD_TEST
{
   [TestFixture]
    public class TestUserLogic
    {
        [Test]
        public void gId()
        {
            UserLogic userLogic = new UserLogic();
            UserDtl user = userLogic.GetUserById(1);
            Assert.IsNotNull(user); 
        }

        [Test]
        public void Register()
        {
            UserLogic userLogic = new UserLogic();
            UserDtl user = new UserDtl()
            {
                firstName ="shuklai",
                lastName = "bhaiya",
                userName = "shukla",
                password = "12345678",
                email = "shukla@gmail.com",
                contactNumber =9149850424,
                active = true,
                role = 3,
            };
            userLogic.Register(user);
            UserDtl user1 = userLogic.GetUserById(12);
            Assert.IsNotNull(user1);
        }

        [Test]
        public void GetAllUser()
        {
            UserLogic userLogic = new UserLogic();
            IList<UserDtl> p = userLogic.GetAllUsers();
            Assert.IsNotNull(p);
        }

        [Test]
        public void BlockUser()
        {
            UserLogic userLogic = new UserLogic();
            userLogic.BlockUser(2);
            UserDtl user = userLogic.GetUserById(2);
            Assert.IsTrue(user.active == false);

        }

        [Test]
        public void UnBlockUser()
        {
            UserLogic userLogic = new UserLogic();
            userLogic.UnBlockUser(2);
            UserDtl user = userLogic.GetUserById(2);
            Assert.IsTrue(user.active == true);

        }


        [Test]
        public void getskillbyid()
        {
            UserLogic userLogic = new UserLogic();
            IList<SkillDtl> p= userLogic.GetSkillById(2);
            Assert.IsNotNull(p);
        }
  
    }
}
