/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.daos;

import com.btljava.helper.DatabaseHelper;
import com.btljava.model.benhnhan;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface IBenhNhan {
    public boolean insert(benhnhan bv) throws Exception;
    public boolean update(benhnhan bv) throws Exception;
    
    public boolean updates(benhnhan bv) throws Exception;
    
    public boolean delete(String bv) throws Exception;
    
    public boolean deletes(String bv) throws Exception;
    
    public List<benhnhan> findAll() throws Exception;
    
    
    public List<benhnhan> banhnhancovid19() throws Exception;
    
    public List<benhnhan> chuathanhtoan() throws Exception;
    
    
    public List<benhnhan> benhnhandacbiet() throws Exception;
    
    public List<benhnhan> benhdichuyen() throws Exception;
    
    public List<benhnhan> benhhiemgap() throws Exception;
    public List<benhnhan> timkiem(String s) throws Exception;
    
    
    public benhnhan findbyid(int n) throws Exception;
    
    public benhnhan findby(String s) throws Exception;
}
