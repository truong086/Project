/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.daos;

import com.btljava.helper.DatabaseHelper;
import com.btljava.model.chucvu;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface Ichucvu {
    public boolean insert(chucvu cv) throws Exception;
    
     public boolean update(chucvu cv) throws Exception;
     
      public boolean delete(String id) throws Exception;
      
       public List<chucvu> findAll() throws Exception;
       
       public List<chucvu> timkiem( String s) throws Exception;
       public chucvu findAllid(int n) throws Exception;
       
       public chucvu findAllids(int n) throws Exception;
}
