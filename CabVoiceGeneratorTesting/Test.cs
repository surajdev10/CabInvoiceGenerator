﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;
using System;

namespace CabInvoiceGeneratorTesting
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// For Single ride Only
        /// </summary>
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnsTotalFare()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 5;
            int time = 6;
            double expected = 56;
            //Act
            double actual = invoiceGenerator.CalculateFare(distance,time);
            //Assert
            Assert.AreEqual(expected,actual);
        }
        /// <summary>
        /// For multiple rides
        /// </summary>
        //[TestMethod]
        //public void GivenMultipleRidesShouldReturnsAggregateTotalFare()
        //{
        //    //Arrange
        //    InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
        //    Ride[] rides = { new Ride(3,25),new Ride(0.5,10) };
        //    double expected = 70;
        //    //Act
        //    double actual = invoiceGenerator.CalculateFare(rides);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        ///
        /// <summary>
        /// Given distance and time of multiple rides should rerurns Totalfare, number of rides and average totalfare
        /// </summary>
        [TestMethod]
        public void GivenMultipleRidesShouldReturnsAggregateTotalFareWithAverage()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides = { new Ride(3, 25), new Ride(0.5, 10) };
            InvoiceSummary expected = new InvoiceSummary(70,rides.Length);
            //Act
            InvoiceSummary actual = invoiceGenerator.CalculateFare(rides);
            //Assert
            Assert.AreEqual(expected, actual);
            //expected.Equals(actual);
        }
    }

}
