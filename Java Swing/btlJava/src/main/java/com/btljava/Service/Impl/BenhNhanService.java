/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IBenhNhanService;
import com.btljava.daos.IBenhNhan;
import com.btljava.dao.impl.benhnhanDao;
import com.btljava.model.benhnhan;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class BenhNhanService implements IBenhNhanService{
    
    private IBenhNhan dao;
    
    public BenhNhanService(){
        dao = new benhnhanDao();
    }
    
    
    @Override
    public boolean insert(benhnhan bv) throws Exception {
        return dao.insert(bv);
    }

    @Override
    public boolean update(benhnhan bv) throws Exception {
        return dao.update(bv);
    }

    @Override
    public boolean updates(benhnhan bv) throws Exception {
        return dao.update(bv);
    }

    @Override
    public boolean delete(String bv) throws Exception {
        return dao.delete(bv);
    }

    @Override
    public boolean deletes(String bv) throws Exception {
        return dao.deletes(bv);
    }

    @Override
    public List<benhnhan> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<benhnhan> banhnhancovid19() throws Exception {
        return dao.banhnhancovid19();
    }

    @Override
    public List<benhnhan> chuathanhtoan() throws Exception {
        return dao.chuathanhtoan();
    }

    @Override
    public List<benhnhan> benhnhandacbiet() throws Exception {
        return dao.benhnhandacbiet();
    }

    @Override
    public List<benhnhan> benhdichuyen() throws Exception {
        return dao.benhdichuyen();
    }

    @Override
    public List<benhnhan> benhhiemgap() throws Exception {
        return dao.benhhiemgap();
    }

    @Override
    public List<benhnhan> timkiem(String s) throws Exception {
       return dao.timkiem(s);
    }

    @Override
    public benhnhan findbyid(int n) throws Exception {
        return dao.findbyid(n);
    }

    @Override
    public benhnhan findby(String s) throws Exception {
        return dao.findby(s);
    }
    
}
