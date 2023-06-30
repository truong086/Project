/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.daos;

import com.btljava.helper.DatabaseHelper;
import com.btljava.model.loaigiuong;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface ILoaiGiuong {
    public boolean insert(loaigiuong lg) throws Exception;
    
    public boolean update(loaigiuong lg) throws Exception;
    
    public boolean delete(String lg) throws Exception;
    
    public List<loaigiuong> findAll() throws Exception;
    
    public loaigiuong findAllid(int id) throws Exception;
    
    public List<loaigiuong> timkiem(String s) throws Exception;
}
