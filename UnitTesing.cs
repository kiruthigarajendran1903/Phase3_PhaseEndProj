﻿using CustomSupportLogger.Models;
using NUnit.Framework;

namespace CustomSupportLogger.Tests
{
    [TestFixture]
    public class UnitTesing
    {
        [Test]
        public void UserInfo_GetUserId_ReturnsUserId()
        {
            // Arrange
            var userInfo = new UserInfo { UserId = 1 };

            // Act
            int userId = userInfo.UserId;

            // Assert
            Assert.AreEqual(1, userId);
        }

        [Test]
        public void UserInfo_SetUserId_CanSetUserId()
        {
            // Arrange
            var userInfo = new UserInfo();

            // Act
            userInfo.UserId = 2;

            // Assert
            Assert.AreEqual(2, userInfo.UserId);
        }

        [Test]
        public void CustLogInfo_GetLogId_ReturnsLogId()
        {
            // Arrange
            var custLogInfo = new CustLogInfo { LogId = 1 };

            // Act
            int logId = custLogInfo.LogId;

            // Assert
            Assert.AreEqual(1, logId);
        }

        [Test]
        public void CustLogInfo_SetLogId_CanSetLogId()
        {
            // Arrange
            var custLogInfo = new CustLogInfo();

            // Act
            custLogInfo.LogId = 2;

            // Assert
            Assert.AreEqual(2, custLogInfo.LogId);
        }
    }
}
