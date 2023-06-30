/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.daos;

import com.btljava.helper.DatabaseHelper;
import com.btljava.model.phanhoi;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface IPhanHoi {
    public boolean insert(phanhoi ph) throws Exception;
    
    public boolean update(phanhoi ph) throws Exception;
    
    public boolean delete(String ph) throws Exception;
    
    public List<phanhoi> findAll(int s) throws Exception;
    
    public phanhoi findbyid(int s) throws Exception;
    
    public List<phanhoi> timkiem(String s) throws Exception;
}
