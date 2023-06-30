/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.daos;

import com.btljava.helper.DatabaseHelper;
import com.btljava.model.doituong;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface Idoituong {
    public boolean insert(doituong dt) throws Exception;
    
    
    public boolean update(doituong dt) throws Exception;

    public boolean delete(String id) throws Exception;

    public List<doituong> findAll() throws Exception;

    public List<doituong> findBy(String id) throws Exception;
    
    
    public doituong findBys(int madoituong) throws Exception;
    
    public doituong findByss(int madoituong) throws Exception;

}
