/*
 * Assignment 2 
 * CIS 411-75
 * Student ID# 5411844
 * Due: 02/02/2024
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Security.Policy;

namespace Assignment2
{
    public partial class Assignment_2 : Form
    {
        public Assignment_2()
        {
            InitializeComponent();
           
        }

        private async void UserSearchButton_Click(object sender, EventArgs e)
        {

            HttpClient myClient = new HttpClient();

            string username = userNameInput.Text;

            myClient.BaseAddress = new Uri("https://api.chess.com/pub/player/");

            myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            myClient.DefaultRequestHeaders.Add("user-Agent", "CIS411/1.0");


            System.IO.Stream resultContent = null;

            var response = await myClient.GetAsync(username);

            if (response.IsSuccessStatusCode)
            {
                resultContent = await response.Content.ReadAsStreamAsync();
            }

            User item = JsonSerializer.Deserialize<User>(resultContent);

            //since the player country is another url, I created another client to be able to deserialize the data and obtain the name of the country 
            HttpClient countryClient = new HttpClient(); 
            countryClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var countryResponse = await countryClient.GetAsync(item.country); //getting the response or data at the url
            Country country = JsonSerializer.Deserialize<Country>(countryResponse.Content.ReadAsStringAsync().Result); //reading and storing it the Country object 

            //Displaying the outputs about the user 
            nameOutput.Text = item.name;
            locationOutput.Text = item.location;
            countryOutput.Text = country.name; //displaying the country name using the country object instead of the user object
            numOfFollowOutput.Text = item.followers.ToString();
            userPhotoOutput.ImageLocation = item.avatar;

        }

    }
    class User
    {//user class to create variables to store the relevant data about the user 
        public string name { get; set; }
        public string location { get; set; }
        public string country { get; set; }
        public int followers { get; set; }
        public string avatar { get; set; }

    }

    class Country
    {//country class to store the country name and display it 
        public string name { get; set; }
    }


}


