/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.daos;

import com.btljava.helper.DatabaseHelper;
import com.btljava.model.giuongngu;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface IGiuongNgu {
    public boolean insert(giuongngu gn) throws Exception;
    
    public boolean update(giuongngu gn) throws Exception;
    
    public boolean delete(String gn) throws Exception;
    
    public List<giuongngu> findAll() throws Exception;
    
    public List<giuongngu> timkiem(String s) throws Exception;
    
    public giuongngu findbyid(int s) throws Exception;
}
