/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IThacMacService;
import com.btljava.daos.IThacMac;
import com.btljava.dao.impl.thacmacDao;
import com.btljava.model.thacmac;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class ThacMacService implements IThacMacService{
    private IThacMac dao;
    
    public ThacMacService(){
        dao = new thacmacDao();
    }
    @Override
    public boolean insert(thacmac tm) throws Exception {
        return dao.insert(tm);
    }

    @Override
    public boolean update(thacmac tm) throws Exception {
        return dao.update(tm);
    }

    @Override
    public boolean delete(String tm) throws Exception {
        return dao.delete(tm);
    }

    @Override
    public List<thacmac> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<thacmac> deleteThacMac() throws Exception {
        return dao.deleteThacMac();
    }

    @Override
    public thacmac findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }

    @Override
    public List<thacmac> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }
    
}
