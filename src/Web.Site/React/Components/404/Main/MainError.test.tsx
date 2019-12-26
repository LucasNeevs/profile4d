import React from 'react';
import chai, { expect } from 'chai';
import Enzyme, { shallow } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import chaiEnzyme from 'chai-enzyme';
import MyStateProvider from '../../../Initial/Context/AppContext';
import appData from '../../../Initial/Context/InitialContext';
import MyApp from '../../../Initial/Tests/TestsApp';
import Main from './Main';

chai.use(chaiEnzyme());
Enzyme.configure({ adapter: new Adapter() });

describe('404.Main', (): void => {
  const App = (): React.ReactElement => (
    <MyStateProvider initialContext={appData}>
      <MyApp>
        <Main />
      </MyApp>
    </MyStateProvider>
  );

<<<<<<< HEAD
// i18next.addResourceBundle('PT', '404Main', LanguagePT);
// i18next.addResourceBundle('ENG', '404Main', LanguageENG);

// describe('MainError', (): void => {
//   // beforeEach(() => {
//   //   const [{ Language }] = useStateValue();

//   //   useEffect((): void => {
//   //     if (!i18next.hasResourceBundle('PT', '404Main')) {
//   //       i18next.addResourceBundle('PT', '404Main', LanguagePT);
//   //     }
//   //     if (!i18next.hasResourceBundle('ENG', '404Main')) {
//   //       i18next.addResourceBundle('ENG', '404Main', LanguageENG);
//   //     }
//   //     // return type void != (): void... so as unknown as void
//   //     return ((): void => {
//   //       i18next.removeResourceBundle('PT', '404Main');
//   //       i18next.removeResourceBundle('ENG', '404Main');
//   //     }) as unknown as void;
//   //   }, []);
//   // });

//   it('Should exist MainError', (): void => {
//     const wrapper = mount(<MyError />);
//     expect(wrapper).to.exist;
//   });
// });

const myLittleTeste: boolean = true;

export default myLittleTeste;
=======
  describe('Smoke Tests', (): void => {
    it('Should exist Main', (): void => {
      const wrapper = shallow(<App />);
      // eslint-disable-next-line no-unused-expressions
      expect(wrapper).to.exist;
    });
  });
  describe('InitialContext Provider', (): void => {
    it('Should exist Main', (): void => {
      const wrapper = shallow(<App />);
      expect(wrapper.find(MyStateProvider).props().initialContext.Ready).equal(false);
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
});
>>>>>>> ea118a47d154a37850670faed407d7a2e8e02125
