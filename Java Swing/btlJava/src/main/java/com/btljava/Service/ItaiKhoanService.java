/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.taikhoan;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface ItaiKhoanService {
    public boolean insert(taikhoan tk) throws Exception;
    
    public boolean update(taikhoan tk) throws Exception;
    
    public boolean doimatkhau(taikhoan tk) throws Exception;
    
    public boolean delete(String tk) throws Exception;
    
    
    public boolean deleteName(String tk) throws Exception;
    
    public List<taikhoan> findAll() throws Exception;
    
    public taikhoan tentaikhoan(int s) throws Exception;
    
    public List<taikhoan> tinkiem(String tks) throws Exception;
    
    public taikhoan findbyid(String tks) throws Exception;
    
    public taikhoan findbyids(int tks) throws Exception;
    
    public taikhoan login(String use, String pass) throws Exception;
    
    public taikhoan logins(String use, String pass) throws Exception;

}
