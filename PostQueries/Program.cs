using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqExercise;


class Program
{
    static void Main (string [] args){


    var posts = PostRepository.GetSamplePosts();
    bool running = true;
    while (running)
        {
         Console.WriteLine("1. Count the total number of post");
         Console.WriteLine("2. Find the post with the most like");
         Console.WriteLine("3. List all posts containing the word \"morning\" (case -insensitive)");
         Console.WriteLine("4. Calculate the average number of likes per post");
         Console.WriteLine("5. Display the top 3 most liked posts in descending order");
         Console.WriteLine("6. Exit");   

         Console.Write(" please enetr your choice (1-6)");
         string choice = Console.ReadLine();


         switch (choice)
            {
                case "1":
                        int totalPosts = posts.Count();
                        Console.WriteLine($"\nTotal number of posts: {totalPosts}");
                    break;

                case "2":
                    var mostLiked = posts.OrderByDescending(p => p.Likes).First();
                        Console.WriteLine($"\nPost with the most likes:\n{mostLiked}");
                break;

                case "3":
                    var morningPosts = posts.Where(p => p.Content.ToLower().Contains("morning"));
                        Console.WriteLine("\nPosts containing \"morning\":");
                        foreach (var post in morningPosts)
                        {
                            Console.WriteLine(post);
                        }
                break;

                case "4":
                    double averageLikes = posts.Average(p => p.Likes);
                    Console.WriteLine($"\nAverage number of likes per post: {averageLikes:F2}");
                break;

                case "5":
                    var top3 = posts.OrderByDescending(p => p.Likes).Take(3);
                        Console.WriteLine("\nTop 3 most liked posts:");
                        foreach (var post in top3)
                        {
                            Console.WriteLine(post);
                        }
                break;

                case "6":
                running = false;
                continue;

                default:
                Console.WriteLine(" Please Choose an option from 1-6 ");
                break;
            }

            }
        }
    }
    