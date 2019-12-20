import React from 'react';
import chai, { expect } from 'chai';
import Enzyme, { shallow, render } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import chaiEnzyme from 'chai-enzyme';
import appData from '../../../Initial/Context/InitialContext';
import MyStateProvider from '../../../Initial/Context/AppContext';
import MyApp from '../../../Initial/Tests/TestsApp';
import Banner from './Banner';

chai.use(chaiEnzyme());
Enzyme.configure({ adapter: new Adapter() });

describe('Home.Banner', (): void => {
  const App = (): React.ReactElement<any> => (
    <MyStateProvider initialContext={appData}>
      <MyApp>
        <Banner />
      </MyApp>
    </MyStateProvider>
  );
  describe('Smoke Tests', (): void => {
    it('Should exist Banner', (): void => {
      const wrapper = shallow(<App />);
      // eslint-disable-next-line no-unused-expressions
      expect(wrapper).to.exist;
    });
  });
  describe('InitialContext Provider', (): void => {
    it('Should return App with Ready context like "false" by default', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.props().initialContext.Ready).equal(false);
    });
    it('Should return App with Theme context like "light" by default', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.props().initialContext.Theme).equal('light');
    });
    it('Should return App with Language context like "PT" by default', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.props().initialContext.Language).equal('PT');
    });
    it('Should return App with ConsentCookie context like "true" by default', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.props().initialContext.ConsentCookie).equal(true);
    });
    it('Should return App with Name context like "Profile4d" by default', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.props().initialContext.Name).equal('Profile4d');
    });
    it('Should return App with Email context like "empty" by default', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.props().initialContext.Email).equal('');
    });
    it('Should return App with KeepConnected context like "false" by default', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.props().initialContext.KeepConnected).equal(false);
    });
    it('Should return App with Drawer context like "false" by default', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.props().initialContext.Drawer).equal(false);
    });
    it('Should return App with IsAuthenticated context like "false" by default', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.props().initialContext.IsAuthenticated).equal(false);
    });
  });
  describe('Childrens Return', (): void => {
    it('Should exist Typography', (): void => {
      const wrapper = render(
        <MyStateProvider initialContext={appData}>
          <MyApp>
            <Banner />
          </MyApp>
        </MyStateProvider>
      );
      expect(wrapper).equal(true);
    });
  });
});
