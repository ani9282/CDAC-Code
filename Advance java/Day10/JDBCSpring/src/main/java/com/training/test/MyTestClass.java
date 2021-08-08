package com.training.test;

import java.text.ParseException;
import java.util.List;
import java.util.Scanner;


import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import com.training.beans.Product;
import com.training.service.ProductService;



public class MyTestClass {

	public static void main(String[] args) throws ParseException {
		Scanner sc=new Scanner(System.in);
		int choice=0;
		ApplicationContext ctx=new ClassPathXmlApplicationContext("MyProduct.xml"); 
		ProductService ps=(ProductService) ctx.getBean("productServiceImpl");
		
		do {
		System.out.println("1.Add"+"\n2.delete"+"\n3.Update"+"\n4.Read All"+"\n5.Read By Id"+"\n6.Exit");
		System.out.println("Enter choice:");
		choice=sc.nextInt();
		switch(choice) {
		
		case 1:
			int n=ps.addProduct();
			if(n>0) {
				System.out.println("Product Added Successfully!!!");
			}
			break;
		
		case 2:
			System.out.println("enter id");
			int id=sc.nextInt();
			int n1=ps.deleteproduct(id);
			if(n1>0)
			{
				System.out.println("product delete successfully");
			}
			else
			{
				System.out.println("Error occur");
			}
			
			break;
			
		case 3:
			System.out.println("enter id");
			int id1=sc.nextInt();
			System.out.println("enter name");
			String nm=sc.next();
			int n2=ps.updateproduct(nm,id1);
			if(n2>0)
			{
				System.out.println("product update successfully");
			}
			else
			{
				System.out.println("Error occur");
			}
			
			break;
			
		case 4:
			List<Product> plist=ps.getAllProduct();
			for(Product p:plist) {
				System.out.println(p);
			}
			break;
			
		case 5:
			
			break;
			
		case 6:
			sc.close();
			System.exit(0);
			break;
		}
		}while(choice!=6);
	}

}
