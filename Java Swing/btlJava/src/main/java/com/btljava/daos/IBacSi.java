/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.daos;

import com.btljava.helper.DatabaseHelper;
import com.btljava.model.bacsi;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface IBacSi {
    public boolean insert(bacsi nv) throws Exception;
    
    public boolean update(bacsi nv) throws Exception;
    
    public boolean updates(bacsi nv) throws Exception;
    
    public boolean delete(String nv) throws Exception;
    public boolean deletes(String nv) throws Exception;
    
    
    public List<bacsi> fiindAll() throws Exception;
    public List<bacsi> timkiem(String s) throws Exception;
    
    public bacsi findby(String id) throws Exception;
    
    public bacsi finbyid(int id) throws Exception;
}
