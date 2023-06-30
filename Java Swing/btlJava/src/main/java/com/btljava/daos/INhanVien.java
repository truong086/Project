/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.daos;

import com.btljava.helper.DatabaseHelper;
import com.btljava.model.nhanvien;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface INhanVien {
    public boolean insert(nhanvien nv) throws Exception;
    
    public boolean update(nhanvien nv) throws Exception;
    
    public boolean updates(nhanvien nv) throws Exception;
    
    public boolean delete(String nv) throws Exception;
    
    public boolean deletes(String nv) throws Exception;
    
    public List<nhanvien> fiindAll() throws Exception;
    
    public List<nhanvien> timkiem(String s) throws Exception;
    
    public nhanvien findby(String id) throws Exception;
    
    public nhanvien finbyid(int id) throws Exception;
    
    public List<nhanvien> chucvu(int chucvu) throws Exception;
}
