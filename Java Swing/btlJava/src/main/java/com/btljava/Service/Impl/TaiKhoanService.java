/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.ItaiKhoanService;
import com.btljava.daos.Itaikhoan;
import com.btljava.dao.impl.taikhoanDao;
import com.btljava.model.taikhoan;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class TaiKhoanService implements ItaiKhoanService{
    private Itaikhoan dao;
    
    public TaiKhoanService(){
        dao = new taikhoanDao();
    }
    @Override
    public boolean insert(taikhoan tk) throws Exception {
        return dao.insert(tk);
    }

    @Override
    public boolean update(taikhoan tk) throws Exception {
        return dao.update(tk);
    }

    @Override
    public boolean doimatkhau(taikhoan tk) throws Exception {
        return dao.doimatkhau(tk);
    }

    @Override
    public boolean delete(String tk) throws Exception {
        return dao.delete(tk);
    }

    @Override
    public boolean deleteName(String tk) throws Exception {
        return dao.deleteName(tk);
    }

    @Override
    public List<taikhoan> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public taikhoan tentaikhoan(int s) throws Exception {
        return dao.tentaikhoan(s);
    }

    @Override
    public List<taikhoan> tinkiem(String tks) throws Exception {
        return dao.tinkiem(tks);
    }

    @Override
    public taikhoan findbyid(String tks) throws Exception {
        return dao.findbyid(tks);
    }

    @Override
    public taikhoan findbyids(int tks) throws Exception {
        return dao.findbyids(tks);
    }

    @Override
    public taikhoan login(String use, String pass) throws Exception {
        return dao.login(use, pass);
    }

    @Override
    public taikhoan logins(String use, String pass) throws Exception {
        return dao.logins(use, pass);
    }
    
}
