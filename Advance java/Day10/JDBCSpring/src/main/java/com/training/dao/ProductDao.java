package com.training.dao;

import java.util.List;

import com.training.beans.Product;

public interface ProductDao 
{
	List<Product> getAllProduct();

	int addProduct(Product p);

	int deleteproduct(int id);

	int updateproduct( String nm,int id1);
}
