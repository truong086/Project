/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.daos;

import com.btljava.helper.DatabaseHelper;
import com.btljava.model.cuochen;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface ICuocHen {
    public boolean insert(cuochen ch) throws Exception;
    
    public boolean update(cuochen ch) throws Exception;
    
    public boolean delete(String ch) throws Exception;
    
    public List<cuochen> findAll() throws Exception;
    
    public List<cuochen> timkiem(String s) throws Exception;
    
    public cuochen findbyid(int s) throws Exception;
}
