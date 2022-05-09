import java.util.Scanner;
import java.util.ArrayList;
import java.util.Collections;

public class Main {
    
    public static void main(String[] args) {
      
        //create my scanner to read user input
        Scanner myScanner = new Scanner (System.in);


      //Create my array it will be of objects 
        ArrayList<String> restaurants = new ArrayList<String>();
        ArrayList<Integer> ratings = new ArrayList<Integer>();

      //Hard code data into the array
      restaurants.add("Olive Garden");
      ratings.add(3);
      

      //C -- Add a new restaurant and rating 
      
      System.out.println("Please enter in the name of the restaurant you are wanting to add.");
      String restaurantName = myScanner.nextLine();
      restaurants.add(restaurantName);

      System.out.println("Please enter a rating for the restuarant.");
      int restaurantRating = myScanner.nextInt();
      ratings.add(restaurantRating);
      



      //R-- Read the restaurants and rating 

      
          for (String aRestaruant: restaurants)
          {
              System.out.println(aRestaruant);
          }
          for (Integer aRating: ratings)
          {
            System.out.println(aRating);
          }
      

      //U -- the rating for the restaurant 

      //D -- Delete the restaurant


    }
  }
  