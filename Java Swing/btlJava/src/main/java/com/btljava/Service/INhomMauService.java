/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.nhommau;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface INhomMauService {
    public boolean insert(nhommau nm) throws Exception;
    public boolean update(nhommau nm) throws Exception;
    
    public boolean delete(String nm) throws Exception;
    
    public List<nhommau> findAll() throws Exception;
    
    public List<nhommau> TimKiem(String s) throws Exception;
    
    public nhommau findAllid(int id) throws Exception;
}
