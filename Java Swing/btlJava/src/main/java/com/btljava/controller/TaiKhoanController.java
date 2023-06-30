/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.Impl.TaiKhoanService;
import com.btljava.Service.ItaiKhoanService;
import com.btljava.daos.Itaikhoan;
import com.btljava.dao.impl.taikhoanDao;
import com.btljava.model.taikhoan;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class TaiKhoanController {
    private ItaiKhoanService dao;
    
    public TaiKhoanController(){
        dao = new TaiKhoanService();
    }
    
    public boolean insert(taikhoan tk) throws Exception {
        return dao.insert(tk);
    }

    
    public boolean update(taikhoan tk) throws Exception {
        return dao.update(tk);
    }

    
    public boolean doimatkhau(taikhoan tk) throws Exception {
        return dao.doimatkhau(tk);
    }

    
    public boolean delete(String tk) throws Exception {
        return dao.delete(tk);
    }

    
    public boolean deleteName(String tk) throws Exception {
        return dao.deleteName(tk);
    }

    
    public List<taikhoan> findAll() throws Exception {
        return dao.findAll();
    }

    
    public taikhoan tentaikhoan(int s) throws Exception {
        return dao.tentaikhoan(s);
    }

    
    public List<taikhoan> tinkiem(String tks) throws Exception {
        return dao.tinkiem(tks);
    }

    
    public taikhoan findbyid(String tks) throws Exception {
        return dao.findbyid(tks);
    }

    
    public taikhoan findbyids(int tks) throws Exception {
        return dao.findbyids(tks);
    }

    
    public taikhoan login(String use, String pass) throws Exception {
        return dao.login(use, pass);
    }

    
    public taikhoan logins(String use, String pass) throws Exception {
        return dao.logins(use, pass);
    }
}
